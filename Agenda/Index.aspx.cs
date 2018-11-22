using System;
using System.Data;
using System.Web.UI.WebControls;

namespace Agenda
{
    public partial class Index : System.Web.UI.Page
    {
        DataSet dsFeriados = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            dsFeriados.ReadXml(AppDomain.CurrentDomain.BaseDirectory.ToString() +  "Feriados.xml");
        }

        protected void Calendario_SelectionChanged(object sender, EventArgs e)
        {
            lblSelecao.Text = "Dia(s) selecionado(s): ";
            foreach (DateTime dia in Calendario.SelectedDates)
            {
                lblSelecao.Text += dia.ToString("dd/MM/yyyy") + "<br>";
            }
        }

        protected void Calendario_DayRender(object sender, System.Web.UI.WebControls.DayRenderEventArgs e)
        {
            string dia;
            DateTime feriado;
            Style estilo = new Style();

            estilo.ForeColor = System.Drawing.Color.White;
            estilo.BackColor = System.Drawing.Color.Blue;

            foreach (DataRow linha in dsFeriados.Tables[0].Rows)
            {
                dia = linha["Data"].ToString();
                feriado = DateTime.Parse(dia);

                if (e.Day.Date == feriado || e.Day.IsOtherMonth)
                {
                    e.Cell.ApplyStyle(estilo);
                }
            }
        }
    }
}