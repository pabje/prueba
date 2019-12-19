using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webservices
{
    public class datos
    {
        List<direccionesweb> _dirweb;
        //private int suc;

        public datos() {
            _dirweb = new List<direccionesweb>();
        }
        public List<direccionesweb> dirweb
        {
            get
            {
                return _dirweb;
            }

            set
            {
                _dirweb = value;
            }
        }
        public void consultacodigo(string cod, int suc)
        {
            using (websEntities dw = new websEntities())
            {
                _dirweb = dw.direccioneswebs
                          .Where(di => di.diw_cod.Substring(0, suc) == cod)
                          .OrderBy(di => di.diw_cod)
                          .ToList();
            }
        } 
        public void consultadireccion(string dir)
        {
            using (websEntities dw = new websEntities())
            {
                _dirweb = dw.direccioneswebs
                          .Where(di => di.diw_dir.Contains(dir))
                          .OrderBy(di => di.diw_cod)
                          .ToList();
            }
        }
        public void consultadescripcion(string des)
        {
            using (websEntities dw = new websEntities())
            {
                _dirweb = dw.direccioneswebs
                          .Where(di => di.diw_des.Contains(des))
                          .OrderBy(di => di.diw_cod)
                          .ToList();
            }
        }
        public void consultafechas(DateTime fed, DateTime feh)
        {
            using (websEntities dw = new websEntities())
            {
                _dirweb = dw.direccioneswebs
                          .Where(di => di.diw_fec >= fed && di.diw_fec <= feh)
                          .OrderBy(di => di.diw_cod)
                          .ToList();
            }
        }
        public void consultacoddir(string cod, int suc, string dir)
        {
            using (websEntities dw = new websEntities())
            {
                _dirweb = dw.direccioneswebs
                          .Where(di => di.diw_cod.Substring(0,suc) == cod && di.diw_dir.Contains(dir))
                          .OrderBy(di => di.diw_cod)
                          .ToList();
            }
        }

        public void consultacoddirdes(string cod, int suc, string dir, string des)
        {
            using (websEntities dw = new websEntities())
            {
                _dirweb = dw.direccioneswebs
                          .Where(di => di.diw_cod.Substring(0, suc) == cod && di.diw_dir.Contains(dir) && di.diw_des.Contains(des))
                          .OrderBy(di => di.diw_cod)
                          .ToList();
            }
        }
        public void consultacoddes(string cod, int suc, string des)
        {
            using (websEntities dw = new websEntities())
            {
                _dirweb = dw.direccioneswebs
                          .Where(di => di.diw_cod.Substring(0,suc) == cod && di.diw_des.Contains(des))
                          .OrderBy(di => di.diw_cod)
                          .ToList();
            }
        }
        public void consultacodfec(string cod, int suc, DateTime  fed, DateTime feh)
        {
            using (websEntities dw = new websEntities())
            {
                _dirweb = dw.direccioneswebs
                          .Where(di => di.diw_cod.Substring(0,suc) == cod && di.diw_fec >= fed && di.diw_fec <= feh)
                          .OrderBy(di => di.diw_cod)
                          .ToList();
            }
        }
        public void consultadirfec(string dir, DateTime fed, DateTime feh)
        {
            using (websEntities dw = new websEntities())
            {
                _dirweb = dw.direccioneswebs
                          .Where(di => di.diw_dir.Contains(dir) && di.diw_fec >= fed && di.diw_fec <= feh)
                          .OrderBy(di => di.diw_cod)
                          .ToList();
            }
        }
        public void consultadesfec(string des, DateTime fed, DateTime feh)
        {
            using (websEntities dw = new websEntities())
            {
                _dirweb = dw.direccioneswebs
                          .Where(di => di.diw_des.Contains(des) && di.diw_fec >= fed && di.diw_fec <= feh)
                          .OrderBy(di => di.diw_cod)
                          .ToList();
            }
        }
        public void consultadirdes(string dir,string des)
        {
            using (websEntities dw = new websEntities())
            {
                _dirweb = dw.direccioneswebs
                          .Where(di => di.diw_dir.Contains(dir) && di.diw_des.Contains(des))
                          .OrderBy(di => di.diw_cod)
                          .ToList();
            }
        }
        public void consultacoddirfec(string cod, int suc, string dir, DateTime fed, DateTime feh)
        {
            using (websEntities dw = new websEntities())
            {
                _dirweb = dw.direccioneswebs
                          .Where(di => di.diw_cod.Substring(0, suc) == cod && di.diw_dir.Contains(dir) && di.diw_fec >= fed && di.diw_fec <= feh)
                          .OrderBy(di => di.diw_cod)
                          .ToList();
            }
        }
        public void consultacoddesfec(string cod, int suc, string des, DateTime fed, DateTime feh)
        {
            using (websEntities dw = new websEntities())
            {
                _dirweb = dw.direccioneswebs
                          .Where(di => di.diw_cod.Substring(0, suc) == cod && di.diw_des.Contains(des) && di.diw_fec >= fed && di.diw_fec <= feh)
                          .OrderBy(di => di.diw_cod)
                          .ToList();
            }
        }
        public void consultadirdesfec(string dir, string des, DateTime fed, DateTime feh)
        {
            using (websEntities dw = new websEntities())
            {
                _dirweb = dw.direccioneswebs
                          .Where(di => di.diw_dir.Contains(dir) && di.diw_des.Contains(des) && di.diw_fec >= fed && di.diw_fec <= feh)
                          .OrderBy(di => di.diw_cod)
                          .ToList();
            }
        }
    }
}