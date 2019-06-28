using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectSearch
{
    public partial class GenerateBingoCard : System.Web.UI.Page
    {
        Classes.Card card = new Classes.Card();

        
        protected void Page_Load(object sender, EventArgs e)
        {

            // call the method and pass the parameters
            //card.genCard(NewDataGrid, grid2, grid3, grid4, grid5, grid6);

        }
    }
}