﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog
{
    static class global
    {
        public static Form F_curent;
        public static int ctr_log;
        public static string parola_curenta;
        public static string parola_noua;
        public static string nume_curent;
        public static string nume_nou;
        public static string nume_default;
        public static string materie_curenta_elev;
        public static string clasa_curenta;
        public static string clasa_input;
        public static string materie_selectata;
        public static string elev_selectat;
        public static string data_selectata;
        public static int noab_selecata;
        public static int materie_selectata_id;
        public static int id_nume;
        public static int noab;
        public static DateTime data_selectat;
        public static int data_de_sters;
        public static int elev_selectat_id;
        public static Boolean motivat;
        public static double medie;
        public static int nrabsente;
        public static int nrabsentemotivate;
        public static string disciplina_input;
        public static string diriginte;
    }

    public class ClsNumD
    {
        public string check { get; set; }
        public List<MainBody> mainBody { get; set; }
    }
    public class MainBody
    {
        public string Clasa { get; set; }
        public string Nume_Default { get; set; }
    }
}
