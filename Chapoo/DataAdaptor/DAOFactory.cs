﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdaptor
{
    public class DAOFactory
    {
        //Connection Info
        private readonly string ConnectionString = "Data Source=den1.mssql7.gear.host;Initial Catalog=chapoo1819f01;User ID=chapoo1819f01;Password=Pu0Q_utpxc-k";
        private readonly SqlConnection Connection;
        //Instances zodat er niet meer dan 1 bestaat op een moment
        private BestellingsItemDAO BestellingsItemDAO = null;
        private RekeningDAO RekeningDAO = null;
        private TafelDAO TafelDAO = null;
        private WerknemerDAO WerknemerDAO = null;
        private MenuItemDAO MenuItemDAO = null;
        private BestellingDAO BestellingDAO = null;
        //DAOFactory itsself
        public static DAOFactory Instance { get; } = new DAOFactory() ;
        
        public DAOFactory()
        {
            Connection = new SqlConnection(ConnectionString);
        }

        #region proxy constructors
        public BestellingsItemDAO CreateBestellingsItemDAO()
        {
            if(BestellingsItemDAO==null)
            {
                BestellingsItemDAO = new BestellingsItemDAO(Connection);
            }
            return BestellingsItemDAO;
        }

        public RekeningDAO CreateRekeningDAO()
        {
            if (RekeningDAO == null)
            {
                RekeningDAO = new RekeningDAO(Connection);
            }
            return RekeningDAO;
        }
        public BestellingDAO CreateBestellingDAO()
        {
            if (BestellingDAO == null)
            {
                BestellingDAO = new BestellingDAO(Connection);
            }
            return BestellingDAO;
        }
        public TafelDAO CreateTafelDAO()
        {
            if (TafelDAO == null)
            {
                TafelDAO = new TafelDAO(Connection);
            }
            return TafelDAO;
        }

        public WerknemerDAO CreateWerknemerDAO()
        {
            if (WerknemerDAO == null)
            {
                WerknemerDAO = new WerknemerDAO(Connection);
            }
            return WerknemerDAO;
        }

        public MenuItemDAO CreateMenuItemDAO()
        {
            if (MenuItemDAO == null)
            {
                MenuItemDAO = new MenuItemDAO(Connection);
            }
            return MenuItemDAO;
        }
        #endregion
    }
}
