using MassiveDemo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MassiveDemo.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class Products : DynamicModel
    {
        public Products()
            : base("MassiveDemo")
        {

        }

        public override void Validate(dynamic item)
        {
            if (string.IsNullOrEmpty(item.Name))
            {
                Errors.Add("Navn kan ikke være blankt");
            }
        }
    }
}