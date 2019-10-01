namespace ResiMedica.ViewModels
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using ResiMedica.Common.Models;
    using Services;
    using Xamarin.Forms;

    //SetValue se encuentra en BaseViewModel
    public class ProductsViewModel : BaseViewModel
    {
        public ApiService apiService { get; set; }

        private ObservableCollection<Product> products;

        public ObservableCollection<Product> Products {
            get { return this.products; }
            set { this.SetValue(ref this.products, value); }
        }
        public ProductsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadProducts();
                    }
        private async void LoadProducts()
        {
            var response = await this.apiService.GetList<Product>("http://localhost:10606", "/api", "Products");
            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert("Error", response.Message, "Accept");
                return;
            }

            var list = (List<Product>)response.Result;
            this.Products = new ObservableCollection<Product>(list);
        }
    }
}
