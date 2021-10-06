using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Interfaces;
using AppCore.Interfaces;
using Domain.Entities;
using Domain.Enums;

namespace AppCore.Services
{
    public class ProductoService : IProductoService 
    {
        private IProductoModel productoModel;
        public ProductoService(IProductoModel productoModel)
        {
            this.productoModel = productoModel;
        }

        public void Create(Producto t)
        {
            productoModel.Create(t);
        }

        public bool Delete(Producto t)
        {
            return productoModel.Delete(t);
        }

        public Producto[] FindAll()
        {
            return productoModel.FindAll();
        }

        public int GetLastProductoId()
        {
            return productoModel.GetLastProductoId();
        }

        public Producto GetProductoById(int codigo)
        {
            return productoModel.GetProductoById(codigo);
        }

        public string GetProductosAsJson()
        {
            return productoModel.GetProductosAsJson();
        }

        public Producto[] GetProductosByFechaVencimiento(DateTime dt)
        {
            return productoModel.GetProductosByFechaVencimiento(dt);
        }

        public Producto[] GetProductosByRangoPrecio(decimal start, decimal end)
        {
            return productoModel.GetProductosByRangoPrecio(start, end);
        }

        public Producto[] GetProductosByUnidadMedida(UnidadMedida um)
        {
            return productoModel.GetProductosByUnidadMedida(um);
        }

        public Producto[] GetProductosOrderByPrecio()
        {
            return GetProductosOrderByPrecio();
        }

        public int Update(Producto t)
        {
            return productoModel.Update(t);
        }
    }
}
