using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ubicaciones.modelo;

namespace ubicaciones
{
    public partial class Form1 : Form
    {
        string[] lines ;
        List<ubicacion> u = new List<ubicacion>();
        GMap.NET.WindowsForms.GMapOverlay gMapOverlay;

        string path = Environment.CurrentDirectory + "\\data.csv";

        public Form1()
        {
            InitializeComponent();
            fileLogic();
            loadLocations();
        }

        public void loadLocations()
        {
            mapa.MapProvider = GMapProviders.BingMap;
            mapa.Position = new PointLatLng(69.5603, -144.3315);
            mapa.MinZoom = 2;
            mapa.MaxZoom = 24;
            mapa.Zoom = 5;
            Size siz = new System.Drawing.Size(700, 500);
            mapa.DragButton = MouseButtons.Left;
            mapa.ClientSize = siz;
            gMapOverlay = new GMap.NET.WindowsForms.GMapOverlay("markers");
            gMapOverlay.IsVisibile = true;


            for (var i = 0; i < u.Count; i++)
            {
                double la = u[i].altitude1;
                double lon = u[i].longitude1;
                var marker = new GMarkerGoogle(new PointLatLng(la, lon), GMarkerGoogleType.orange_dot);

                marker.IsVisible = true;

                gMapOverlay.Markers.Add(marker);

                mapa.Overlays.Add(gMapOverlay);

            }


            //for (var i = 501; i < 1000; i++)
            //{
            //    double la = u[i].altitude1;
            //    double lon = u[i].longitude1;
            //    var marker = new GMarkerGoogle(new PointLatLng(la, lon), GMarkerGoogleType.yellow_dot);

            //    marker.IsVisible = true;

            //    gMapOverlay.Markers.Add(marker);

            //    mapa.Overlays.Add(gMapOverlay);

            //}

        }



        public void fileLogic()
        {
            lines = File.ReadAllLines("./dt.csv");
            lines = lines.Skip(1).ToArray();
            double la;
            double lon;
            double mag;

            string las;
            string lons;
            string mags;

            foreach (var l in lines)

            {
                
                var valores = l.Split(',');
                las = valores[1];
                las.Replace(',', '.');
                lons = valores[2];
                lons.Replace(',', '.');
                mags = valores[4];
                mags.Replace(',', '.');
                if (!las.Equals("")&& !lons.Equals("")&& !mags.Equals(""))
                {
                    la = double.Parse(las, CultureInfo.InvariantCulture);
                    lon = double.Parse(lons, CultureInfo.InvariantCulture);
                    mag = double.Parse(mags, CultureInfo.InvariantCulture);

                    saveLocation(la, lon, mag);
                }
                 
                //Console.WriteLine("latitude = " + valores[1] + " longitude = " + valores[2] + " magnitude = " + valores[4]);
            }
        }

        public void saveLocation(double la, double lon, double mag)
        {
           ubicacion u1 = new ubicacion(la, lon, mag);
            u.Add(u1);
            //Console.WriteLine("latitude = " + u1.altitude1 + " longitude = " + u1.longitude1 + " magnitude = " + u1.magnitude1);
        }

        private void act_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < 500; i++)
            {
                double la = u[i].altitude1;
                double lon = u[i].longitude1;
            var marker = new GMarkerGoogle(new PointLatLng(la, lon), GMarkerGoogleType.green);
            //var marker1 = new GMarkerGoogle(new PointLatLng(la, lon), GMarkerGoogleType.green);
            //var marker2 = new GMarkerGoogle(new PointLatLng(la, lon), GMarkerGoogleType.green);
            //mapa.Position = new PointLatLng(la, lon);
            //var marker = new GMarkerGoogle(new PointLatLng(61.5165, 61.5165), GMarkerGoogleType.green);
            //var marker1 = new GMarkerGoogle(new PointLatLng(35.7415, -117.5508333), GMarkerGoogleType.green);
            //var marker2 = new GMarkerGoogle(new PointLatLng(35.527, -117.3821667), GMarkerGoogleType.green);
            marker.IsVisible = true;
                //marker1.IsVisible = true;
                //marker2.IsVisible = true;
                gMapOverlay.Markers.Add(marker);
                //gMapOverlay.Markers.Add(marker1);
                //gMapOverlay.Markers.Add(marker2);
                mapa.Overlays.Add(gMapOverlay);

            }
            //double zoomAtual = mapa.Zoom;
            //mapa.Zoom = zoomAtual + 1;
            //mapa.Zoom = zoomAtual;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (var i = 501; i < 1000; i++)
            {
                double la = u[i].altitude1;
                double lon = u[i].longitude1;
                var marker = new GMarkerGoogle(new PointLatLng(la, lon), GMarkerGoogleType.green);
                //var marker1 = new GMarkerGoogle(new PointLatLng(la, lon), GMarkerGoogleType.green);
                //var marker2 = new GMarkerGoogle(new PointLatLng(la, lon), GMarkerGoogleType.green);
                //mapa.Position = new PointLatLng(la, lon);
                //var marker = new GMarkerGoogle(new PointLatLng(61.5165, 61.5165), GMarkerGoogleType.green);
                //var marker1 = new GMarkerGoogle(new PointLatLng(35.7415, -117.5508333), GMarkerGoogleType.green);
                //var marker2 = new GMarkerGoogle(new PointLatLng(35.527, -117.3821667), GMarkerGoogleType.green);
                marker.IsVisible = true;
                //marker1.IsVisible = true;
                //marker2.IsVisible = true;
                gMapOverlay.Markers.Add(marker);
                //gMapOverlay.Markers.Add(marker1);
                //gMapOverlay.Markers.Add(marker2);
                mapa.Overlays.Add(gMapOverlay);

            }
            //double zoomAtual = mapa.Zoom;
            //mapa.Zoom = zoomAtual + 1;
            //mapa.Zoom = zoomAtual;
        }
    }
}
