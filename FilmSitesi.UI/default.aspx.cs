using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FilmSitesi.BLL;
using FilmSitesi.DTO;

namespace FilmSitesi.UI
{
    public partial class _default1 : System.Web.UI.Page
    {
        FilmDetayController fdc;
        protected void Page_Load(object sender, EventArgs e)
        {
            fdc = new FilmDetayController();

            rptFilmler.DataSource=fdc.VeriGetir();
            rptFilmler.DataBind();

        }
    }
}