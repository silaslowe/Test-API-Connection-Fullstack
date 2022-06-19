using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace MusicTaxApp.Models;

public class Expense
{
    public Guid Guid { get; set; }
    [StringLength(30)] public string Name { get; set; }
    public int Cost { get; set; }
    public int Tax { get; set; }
    [StringLength(30)]public string Vendor { get; set; }
    [StringLength(300)]public string Notes { get; set; }
}

