using System;
using System.Collections.Generic;
using System.Text;

namespace FitBites.Core.Ingredients;

public sealed record Micros
{
    public Micros(Vitamins vitamins, Minerals minerals)
    {
        Vitamins = vitamins;
        Minerals = minerals;
    }
    public Vitamins Vitamins { get;}
    public Minerals Minerals { get;}
        
    
}
