﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP2007_S2016_Lesson10CC.Models
{
    public class BuffType
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public BuffType()
        {

        }

        /// <summary>
        /// This constructor takes one paramter - Name
        /// </summary>
        /// <param name="Name"></param>
        public BuffType(string Name)
        {
            this.Name = Name;
        }

        public virtual int BuffTypeId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual List<FoodMenu> FoodMenu { get; set; }
    }
}
}