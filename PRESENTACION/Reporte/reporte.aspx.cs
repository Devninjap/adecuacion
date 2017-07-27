using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;

namespace PRESENTACION.Reporte
{
	public partial class reporte : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

			if(!IsPostBack){
				//var estudiantes = new blEstudiante().listarTodos();
				//var adecuaciones = new blAdecuacion().listarTodos();
				//var detalles = new blDetalleAdecuacion().listarTodos();
				//var equivalencias = new blEquivalenciaAsignatura().listarTodos();
				var idAdecuacion = Request.QueryString["idAdecuacion"];
				var query = new blAdecuacion().consultaReporte(int.Parse(idAdecuacion));


				ReportDataSource datasource1 = new ReportDataSource("AdecuacionDS", query);
				ReportDataSource datasource2 = new ReportDataSource("DetalleDS", query);
				ReportDataSource datasource3 = new ReportDataSource("EquivalenciasDS", query);
				ReportDataSource datasource4 = new ReportDataSource("EstudianteDS", query);
				ReportViewer1.LocalReport.DataSources.Add(datasource1);
				ReportViewer1.LocalReport.DataSources.Add(datasource2);
				ReportViewer1.LocalReport.DataSources.Add(datasource3);
				ReportViewer1.LocalReport.DataSources.Add(datasource4);
				ReportViewer1.LocalReport.Refresh();
			}

			//List<ENTIDADES.adecuacion> listaAdecuacion = new List<ENTIDADES.adecuacion>();
			//listaAdecuacion.Add(new NEGOCIO.blAdecuacion().consultar(1));

			//List<ENTIDADES.detalleAdecuacion> listaDetalle = new NEGOCIO.blDetalleAdecuacion().listarTodos().Where(x => x.idAdecuacion == 1).ToList();

			//List<ENTIDADES.equivalenciaAsignatura> listaEquivalencias = new NEGOCIO.blEquivalenciaAsignatura().listarTodos().Join(new NEGOCIO.blDetalleAdecuacion().listarTodos()
			//	, equivalencia => equivalencia.idEquivalencia
			//	, detalle => detalle.idEquivalencia
			//	, (equivalencia, detalle) => equivalencia).ToList();

			//List<ENTIDADES.estudiante> listaEstudiante = new List<ENTIDADES.estudiante>();
			//listaEstudiante.Add(new NEGOCIO.blEstudiante().consultar(1));
			//List<ENTIDADES.equivalenciaAsignatura> listaEquivalencias = new List<ENTIDADES.equivalenciaAsignatura>();
			//listaEquivalencias.Add(new NEGOCIO.blEquivalenciaAsignatura().consultar(1));


			//ReportDataSource datasource1 = new ReportDataSource("AdecuacionDS", listaAdecuacion);
			//ReportDataSource datasource2 = new ReportDataSource("DetalleDS", listaDetalle);
			//ReportDataSource datasource3 = new ReportDataSource("EquivalenciasDS", listaEquivalencias);
			//ReportDataSource datasource4 = new ReportDataSource("EstudianteDS", listaEstudiante);
			//ReportViewer1.LocalReport.DataSources.Add(datasource1);
			//ReportViewer1.LocalReport.DataSources.Add(datasource2);
			//ReportViewer1.LocalReport.DataSources.Add(datasource3);
			//ReportViewer1.LocalReport.DataSources.Add(datasource4);
			//if (!IsPostBack)
			//{
			//	var idEquivalencia = Request.QueryString["idEquivalencia"];
			//	var idEstudia = Request.QueryString["idEstudiante"];
			//	//var binding = new BindingSource();
			//	//ReportDataSource ds1 = new ReportDataSource("EquivalenciaDS", new NEGOCIO.blEquivalenciaAsignatura().listarTodos().Select(x => x.idEquivalencia == int.Parse(idEquivalencia)));
			//	ReportDataSource ds1 = new ReportDataSource("EquivalenciasDS", new NEGOCIO.blEquivalenciaAsignatura().listarTodos());
			//	//ReportViewer1.DataBind();

			//	List<ENTIDADES.estudiante> listaEstudiante = new List<ENTIDADES.estudiante>();
			//	listaEstudiante.Add(new NEGOCIO.blEstudiante().consultar(int.Parse(Request.QueryString["idEstudiante"])));
			//	ReportDataSource ds2 = new ReportDataSource("EstudianteDS", listaEstudiante);

			//	ReportViewer1.LocalReport.Refresh();

			//	ReportViewer1.LocalReport.DataSources.Add(ds1);
			//	ReportViewer1.LocalReport.DataSources.Add(ds2);
			//	//ReportViewer1.LocalReport.Refresh();
			//	Label1.Text = idEquivalencia;
			//}

		}

		protected void ReportViewer1_Init(object sender, EventArgs e)
		{

		}
	}
}