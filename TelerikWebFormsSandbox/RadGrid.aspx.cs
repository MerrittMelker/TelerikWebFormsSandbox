using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using TessituraIntegration.TessituraWebAPI;

namespace TelerikWebFormsSandbox
{
    public class ProductionsModuleItemsService
    {
        public DataTable GetItems(int startRowIndex, int maximumRows)
        {
            //var viewData = new List<ProductionsModuleItemViewModel>();
            //var items = manager.GetProductionsModuleItems().OrderBy(sortExpression).Skip(startRowIndex).Take(maximumRows);
            //foreach (var item in items)
            //{
            //    var viewModel = new ProductionsModuleItemViewModel();
            //    ProductionsModuleItemsViewModelTranslator.ToViewModel(item, viewModel, manager);
            //    viewData.Add(viewModel);
            //}
            //return viewData;

            if (result == null)
            {
                GetResult();
            }

            return result.Tables[0];
        }

         public DataTable GetItems()
        {
            //var viewData = new List<ProductionsModuleItemViewModel>();
            //var items = manager.GetProductionsModuleItems().OrderBy(sortExpression).Skip(startRowIndex).Take(maximumRows);
            //foreach (var item in items)
            //{
            //    var viewModel = new ProductionsModuleItemViewModel();
            //    ProductionsModuleItemsViewModelTranslator.ToViewModel(item, viewModel, manager);
            //    viewData.Add(viewModel);
            //}
            //return viewData;

            if (result == null)
            {
                GetResult();
            }

            return result.Tables[0];
        }

        public int GetTotalItemsCount()
        {
            //return manager.GetProductionsModuleItems().Count();
            return result.Tables[0].Rows.Count;
        }

        private static void GetResult()
        {
            var myBinding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
            myBinding.MaxReceivedMessageSize = 2147483647;
            var myEndpoint =
                new EndpointAddress("https://gatewaytest.omahaperformingarts.org/TessituraWebAPItest/Tessitura.asmx");
            using (var soapClient = new TessituraSoapClient(myBinding, myEndpoint))
            {
                result = soapClient.GetProductionsEx3(string.Empty, "1/1/2015", "2/1/2015", string.Empty,
                string.Empty, -1, string.Empty, 6, 1, string.Empty, string.Empty, string.Empty, 0,
                string.Empty, string.Empty, string.Empty);
            }
        }

        private static DataSet result;
    }

    public partial class RadGrid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ProductionsModuleItemsMaster_SortCommand(object sender, GridSortCommandEventArgs e)
        {
            productionsModuleItemsDataSource.SelectParameters[0].DefaultValue = e.SortExpression;
            productionsModuleItemsDataSource.SelectParameters[1].DefaultValue = e.NewSortOrder.ToString();
        }
    }
}