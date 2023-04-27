using System;
using System.Collections.Generic;

namespace ProyectoFinal.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string NombreProducto { get; set; } = null!;

    public decimal Precio { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Detallesventum> Detallesventa { get; set; } = new List<Detallesventum>();
}
