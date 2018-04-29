﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Zxw.Framework.NetCore.Models;

namespace Zxw.Framework.Website.Models
{
    [Table("SysMenu")]
    public class SysMenu:BaseModel<int>
    {
        [Key]
        [Column("SysMenuId")]
        public override int Id { get; set; }

        public int ParentId { get; set; } = 0;

        [MaxLength(50)]
        public string MenuPath { get; set; }

        [Required]
        [MaxLength(20)]
        public string MenuName { get; set; }

        [MaxLength(50)]
        public string MenuIcon { get; set; }

        [Required]
        [MaxLength(100)]
        public string Identity { get; set; }

        [Required]
        [MaxLength(200)]
        public string RouteUrl { get; set; }

        public bool Visiable { get; set; } = true;

        public bool Activable { get; set; } = true;

        public int SortIndex { get; set; }
    }
}
