using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ADL
{
    public class AccessDataLayer
    {

        BDRestauranteProyectoLenguajesEntities restaurant = new BDRestauranteProyectoLenguajesEntities();

        /*CRUD PLates Inicio*/
        Plato plato;
        public Boolean InsertPlate(Plato plate)
        {
            restaurant.Plato.Add(plate);
            restaurant.SaveChanges();
            return true;
        }

        public Boolean ModifyPlate(int plateID, Plato plateModify)
        {
            plato = SearchPlateID(plateID);
            plato.Nombre = plateModify.Nombre;
            plato.Descripcion = plateModify.Descripcion;
            plato.Precio = plateModify.Precio;
            plato.Fotografia = plateModify.Fotografia;
            plato.HabilitadoSN = plateModify.HabilitadoSN;
            plato.TiempoPreparacionMinutos = plateModify.TiempoPreparacionMinutos;
            
           restaurant.SaveChanges();
           return true;
        }

        public Plato SearchPlateID(int plateID)
        {
            return restaurant.Plato.Find(plateID);
        }

        public List<Plato> ShowPlates()
        {
           return restaurant.Plato.ToList(); 
        }

        public Boolean DeletePlate(Plato plate)
        {
            restaurant.Plato.Remove(plate);
            restaurant.SaveChanges();
            return true;
        }

        /*CRUD Plates FIN*/


        /*CRUD Order INICIO*/

        Orden order = new Orden();

        public void addOrder(Orden newOrder, List<LineaOrden> orderLines)
        {
            using (BDRestauranteProyectoLenguajesEntities db = new BDRestauranteProyectoLenguajesEntities())
            {
                db.Orden.Add(newOrder);
                db.SaveChanges();
                foreach (LineaOrden line in orderLines)
                {
                    db.LineaOrden.Add(line);
                }
                db.SaveChanges();
            }
        }

        public List<Orden> ordersTable()
        {
            using (BDRestauranteProyectoLenguajesEntities db = new BDRestauranteProyectoLenguajesEntities())
            {
                return db.Orden.ToList();
                //return ToDataTable(db.Orden.ToList());
            }
        }

        public void changeStateOrder(HistoricoCambioEstadoOrden estado)
        {
            using (BDRestauranteProyectoLenguajesEntities db = new BDRestauranteProyectoLenguajesEntities())
            {
                db.HistoricoCambioEstadoOrden.Add(estado);
                db.SaveChanges();
            }
        }

        private Orden findOrder(int orderID)
        {
            using (BDRestauranteProyectoLenguajesEntities db = new BDRestauranteProyectoLenguajesEntities())
            {
                return db.Orden.Find(orderID);
            }
        }

        //private DataTable ToDataTable<T>(List<T> items)
        //{
        //    DataTable dataTable = new DataTable(typeof(T).Name);
        //    PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        //    foreach (PropertyInfo prop in Props)
        //    {
        //        var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
        //        dataTable.Columns.Add(prop.Name, type);
        //    }
        //    foreach (T item in items)
        //    {
        //        var values = new object[Props.Length];
        //        for (int i = 0; i < Props.Length; i++)
        //        {
        //            values[i] = Props[i].GetValue(item, null);
        //        }
        //        dataTable.Rows.Add(values);
        //    }
        //    return dataTable;
        //}

        /*CRUD Order INICIO*/
    }
}
