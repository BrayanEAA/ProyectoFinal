using System;
using System.Collections.Generic;

namespace ProyectoFinal.Models;

public partial class Venta
{
    public int IdVenta { get; set; }

    public int IdCliente { get; set; }

    public string? FechaPedido { get; set; }

    public decimal Total { get; set; }

    public virtual ICollection<Detallesventum> Detallesventa { get; set; } = new List<Detallesventum>();

    public virtual Cliente IdClienteNavigation { get; set; } = null!;
}
