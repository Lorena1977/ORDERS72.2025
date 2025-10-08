using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Orders72.Frontend.Pages.Countries;
using Orders72.Frontend.Repositories;
using Orders72.Frontend.Shared;
using Orders72.Shared.Entities;

namespace Orders72.Frontend.Pages.Categories
{
    [Authorize(Roles = "Admin")]
    public partial class CategoryCreate
    {
        private FormWithName<Category>? categoryForm;
        [Inject] private IRepository Repository { get; set; } = null!;
        [Inject] private NavigationManager NavigationManager { get; set; } = null!;
        [Inject] private SweetAlertService SweetAlertService { get; set; } = null!;

        private Category category = new();

        private async Task CreateAsync()
        {
            var responseHttp = await Repository.PostAsync("/api/categories", category);
            if (responseHttp.Error)
            {
                var message = await responseHttp.GetErrorMessageAsync();
                await SweetAlertService.FireAsync("Error", message);
                return;
            }

            Return();
            var toast = SweetAlertService.Mixin(new SweetAlertOptions
            {
                Toast = true,
                Position = SweetAlertPosition.BottomEnd,
                ShowConfirmButton = true,
                Timer = 3000
            });
            await toast.FireAsync(icon: SweetAlertIcon.Success, message: "Registro creado con �xito.");
        }

        private void Return()
        {
            categoryForm!.FormPostedSuccessfully = true;
            NavigationManager.NavigateTo("/categories");
        }
    }
}