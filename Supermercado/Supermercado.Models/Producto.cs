using System;
using System.ComponentModel.DataAnnotations;

namespace Supermercado.Models
{
    public class Producto
    {
        [Key]
        public int ProductoID { get; set; }  // Refleja la columna ProductoID de la tabla

        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        [Display(Name = "Nombre del Producto")]
        public string NombreProducto { get; set; }  // Refleja la columna NombreProducto

        [Required(ErrorMessage = "La categoría es obligatoria")]
        [Display(Name = "Categoría del Producto")]
        public string Categoria { get; set; }  // Refleja la columna Categoria

        [Required(ErrorMessage = "El precio de compra es obligatorio")]
        [Display(Name = "Precio de Compra")]
        [Range(0.01, 10000.00, ErrorMessage = "El precio debe ser mayor a 0")]
        public decimal PrecioCompra { get; set; }  // Refleja la columna PrecioCompra

        [Required(ErrorMessage = "El precio de venta es obligatorio")]
        [Display(Name = "Precio de Venta")]
        [Range(0.01, 10000.00, ErrorMessage = "El precio debe ser mayor a 0")]
        public decimal PrecioVenta { get; set; }  // Refleja la columna PrecioVenta

        [Required(ErrorMessage = "El stock actual es obligatorio")]
        [Display(Name = "Stock Actual")]
        [Range(0, int.MaxValue, ErrorMessage = "El stock debe ser mayor o igual a 0")]
        public int StockActual { get; set; }  // Refleja la columna StockActual

        [Required(ErrorMessage = "El stock mínimo es obligatorio")]
        [Display(Name = "Stock Mínimo")]
        [Range(0, int.MaxValue, ErrorMessage = "El stock mínimo debe ser mayor o igual a 0")]
        public int StockMinimo { get; set; }  // Refleja la columna StockMinimo

        [Display(Name = "Fecha de Vencimiento")]
        [DataType(DataType.Date)]
        public DateTime? FechaVencimiento { get; set; }  // Refleja la columna FechaVencimiento

        [Display(Name = "Descripción del Producto")]
        public string Descripcion { get; set; }  // Refleja la columna Descripcion
    }
}
