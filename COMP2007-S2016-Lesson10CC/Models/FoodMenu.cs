using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP2007_S2016_Lesson10CC.Models
{
    public class FoodMenu
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public FoodMenu()
        {

        }

        /// <summary>
        /// This constructor takes one parameter - Title
        /// </summary>
        /// <param name="Name"></param>
        public FoodMenu(string Name)
        {
            this.Name = Name;
        }
        [Display(Name = "FoodMenu")]
        public virtual int FoodMenuId { get; set; }
        [Display(Name = "BuffType")]
        public virtual int BuffTypeId { get; set; }
        [Display(Name = "Description")]
        public virtual int ArtistId { get; set; }
        public virtual string Title { get; set; }
        public virtual decimal Price { get; set; }
        [Display(Name = "Album Art URL")]
        public virtual string AlbumArtUrl { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Artist Artist { get; set; }
    }
}