using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ADL;

namespace BLL
{
    public class BussinessLogicLayer
    {
        AccessDataLayer accessData = new AccessDataLayer();
        DataTable dt = new DataTable();

        Validation validation = new Validation();
        Plato plate = new Plato();



        public Boolean InsertPlate(String name, String description, String price, ref byte[] photo, String enabled, String timeToPrepare)
        {
            //if (manejador.validarLenght(nombre) || manejador.revisarTamaño(nombre) > 50 || !manejador.validarCamposTexto(nombre))
            //{
            //    throw new ArgumentException("El espacio de nombre está vacio, sobrepasa el máximo de caracteres permitidos o está compuesta por solo números");
            //}

            //if (manejador.validarLenght(descripcion) || manejador.revisarTamaño(descripcion) > 250 || !manejador.validarCamposTexto(descripcion))
            //{
            //    throw new ArgumentException("El espacio de descripción está vacio, sobrepasa el máximo de caracteres permitidos o está compuesto de solo números");
            //}

            //if (manejador.validarLenght(precio) || !manejador.validarCamposNumeros(precio))
            //{
            //    throw new ArgumentException("El espacio de precio está vacio o no está compuesto solo por números");
            //}

            //if (manejador.validarLenght(habilitado) || manejador.revisarTamaño(nombre) > 1)
            //{
            //    throw new ArgumentException("El espacio de habilitación está vacio");
            //}

            //if (manejador.validarLenght(tiempoPreparacion) || !manejador.validarCamposNumeros(tiempoPreparacion))
            //{
            //    throw new ArgumentException("El espacio de tiempo de preparación está vacio o no contiene solo números");
            //}

            //if (fotografia == null)
            //{
            //    throw new ArgumentNullException("No seleccionó una fotografia");
            //}


            return InsertP(name, description, price, ref photo, enabled, timeToPrepare);
        }

        private Boolean InsertP(String name, String description, String price, ref byte[] fotografia, String enable, String time)
        {
            plate.Nombre = name;
            plate.Descripcion = description;
            plate.Precio = decimal.Parse(price);
            plate.HabilitadoSN = enable;
            plate.TiempoPreparacionMinutos = byte.Parse(time);
            plate.Fotografia = fotografia;

            return accessData.InsertPlate(plate);
        }

        public Boolean ModificarPlato(String nombreBuscar, String nombreNuevo, String descripcionNueva, String precioNuevo, ref byte[] fotografiaNueva, String habilitadoNuevo, String tiempoPreparacionNuevo)
        {

            //if (!manejador.validarCamposTexto(nombreNuevo))
            //{
            //    throw new ArgumentException("El nombre no tiene un formato correcto");
            //}

            //if (!manejador.validarCamposTexto(descripcionNueva))
            //{
            //    throw new ArgumentException("La descripción no tiene un formato correcto");
            //}

            //if (!manejador.validarCamposNumeros(precioNuevo))
            //{
            //    throw new ArgumentException("El precio debe estar compuesto solo por números");
            //}

            //if (!manejador.validarCamposNumeros(tiempoPreparacionNuevo))
            //{
            //    throw new ArgumentException("El tiempo de preparación debe estar compuesto solo por números");
            //}

            return modifyP(nombreBuscar, nombreNuevo, descripcionNueva, precioNuevo, ref fotografiaNueva, habilitadoNuevo, tiempoPreparacionNuevo);
        }

        private Boolean modifyP(String nameToSearch, String newName, String newDescription, String newPrice, ref byte[] newPhoto, String newEnabled, String newTime)
        {
            plate = SearchPlateName(nameToSearch);


            //if (!manejador.validarLenght(nombreNuevo) && manejador.revisarTamaño(nombreNuevo) <= 50)
            //{
            //    plato.Nombre = nombreNuevo;
            //}

            //if (!manejador.validarLenght(descripcionNueva) && manejador.revisarTamaño(descripcionNueva) <= 250)
            //{
            //    plato.Descripcion = descripcionNueva;
            //}

            //if (!manejador.validarLenght(precioNuevo))
            //{
            //    plato.Precio = decimal.Parse(precioNuevo);
            //}

            //if (fotografiaNueva != null)
            //{
            //    plato.Fotografia = fotografiaNueva;
            //}

            //if (!manejador.validarLenght(habilitadoNuevo))
            //{
            //    plato.HabilitadoSN = habilitadoNuevo;
            //}

            //if (!manejador.validarLenght(tiempoPreparacionNuevo))
            //{
            //    plato.TiempoPreparacionMinutos = byte.Parse(tiempoPreparacionNuevo);
            //}

            return accessData.ModifyPlate(plate.PlatoID, plate);
        }

        public Plato SearchPlateName(String name)
        {
            if (validation.validarLenght(name) || !validation.validarCamposTexto(name))
            {
                throw new ArgumentException("El formato del nombre no es correcto");
            }

            List<Plato> plates = accessData.ShowPlates();

            foreach (Plato plate in plates)
            {
                if (plate.Nombre.Equals(name))
                {
                    return plate;
                }
            }

            throw new Exception("No se encontró ese plato");
        }

        public Plato BuscarPlatoID(String id)
        {
            if (validation.validarLenght(id) || !validation.validarCamposNumeros(id))
            {
                throw new ArgumentException("El formato del identificador no es correcto");
            }

            plate = accessData.SearchPlateID(int.Parse(id));
            if (plate != null)
            {
                return plate;
            }
            else
            {
                throw new Exception("No se encontró ese plato");
            }

        }

        public Boolean DeletePlate(String name)
        {
            if (validation.validarLenght(name) || !validation.validarCamposTexto(name))
            {
                throw new ArgumentException("El formato del nombre no es correcto");
            }

            plate = SearchPlateName(name);

            return accessData.DeletePlate(plate);
        }


    }
}
