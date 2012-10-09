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

        //public override void Validate(dynamic item)
        //{
        //    ValidateNameNotEmpty(item);
        //    ValidateMaxNameLength(item);
        //}

        //private void ValidateNameNotEmpty(dynamic item)
        //{
        //    if (string.IsNullOrEmpty(item.Name))
        //    {
        //        Errors.Add("Name can not be empty!");
        //    }
        //}

        //private void ValidateMaxNameLength(dynamic item)
        //{
        //    const int MAX_LENGTH = 50;
        //    if (item.Name.Length > MAX_LENGTH)
        //    {
        //        Errors.Add(string.Format("Name can be maximum {0} characters long", MAX_LENGTH));
        //    }
        //}
    }
}