using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.StructuralPattern
{
    /// <summary>   
    /// Car Base component   
    /// </summary>   
    public interface ICar
    {
        string GetDescription();
        double GetCost();
    }
}
