using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace TelerikWebFormsSandbox
{
    public partial class RadSearchBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private static readonly List<String> _myData = new List<string> {"a", "b", "c", "d" };

        [WebMethod]
        public static SearchBoxData GetResults(SearchBoxContext context)
        {
            List<SearchBoxItemData> result = new List<SearchBoxItemData>();

            var filteredData = _myData.Where(x => x.StartsWith(context.Text));

            foreach (var value in filteredData)
            {
                SearchBoxItemData itemData = new SearchBoxItemData();
                itemData.Text = itemData.Value = value;
                result.Add(itemData);
            }
            SearchBoxData res = new SearchBoxData();
            res.Items = result.ToArray();

            return res;
        }

        protected void RadSearchBox1_Search(object sender, SearchBoxEventArgs e)
        {
            Label1.Text = "Text: " + e.Text;
        }
    }
}