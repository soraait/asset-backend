using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class GoodsDetail
    {
        [Key]
        public int GoodsID { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public String GoodsName { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public String GoodsNo { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public String GoodsBrand { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public String GoodsModel { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public String GoodsSerailNumber { get; set; }

      



    }
}
