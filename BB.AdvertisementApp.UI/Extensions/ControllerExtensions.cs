using BB.AdvertisementApp.Common;
using BB.AdvertisementApp.Core;
using Microsoft.AspNetCore.Mvc;

namespace BB.AdvertisementApp.UI.Extensions
{
    public static class ControllerExtensions
    {
        public static IActionResult ResponseRedirectAction<T>(this Controller controller, IResponse<T> response, string actionName, string ControllerName = "")
        {
            if (response.ResponseType == ResponseType.NotFound)
                return controller.NotFound();

            if (response.ResponseType == ResponseType.ValidationError)
            {
                foreach (var error in response.ValidationErrors)
                {
                    controller.ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                    return controller.View(response.Data);
                }
            }

            if (string.IsNullOrWhiteSpace(ControllerName))
            {
                return controller.RedirectToAction(actionName);

            }

            return controller.RedirectToAction(actionName, ControllerName);
        }

        public static IActionResult ResponseRedirectAction(this Controller controller, IResponse response,
            string actionName)
        {
            if (response.ResponseType == ResponseType.NotFound)
                return controller.NotFound();

            return controller.RedirectToAction(actionName);

        }

        public static IActionResult ResponseView<T>(this Controller controller, IResponse<T> response)
        {
            if (response.ResponseType == ResponseType.NotFound)
                return controller.NotFound();

            return controller.View(response.Data);
        }





    }
}
