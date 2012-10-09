using MassiveDemo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MassiveDemo.Domain
{
    public class Products : DynamicModel
    {
        public Products()
            : base("MassiveDemo")
        {

        }

        public override void Validate(dynamic item)
        {
            
        }
    }
}