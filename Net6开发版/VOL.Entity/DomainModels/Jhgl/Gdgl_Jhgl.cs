/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果数据库字段发生变化，请在代码生器重新生成此Model
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VOL.Entity.SystemModels;

namespace VOL.Entity.DomainModels
{
    [Entity(TableCnName = "计划管理",TableName = "Gdgl_Jhgl")]
    public partial class Gdgl_Jhgl:BaseEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="id")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int id { get; set; }

       /// <summary>
       ///开始日期
       /// </summary>
       [Display(Name ="开始日期")]
       [Column(TypeName="date")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime Kaishiriqi { get; set; }

       /// <summary>
       ///地址
       /// </summary>
       [Display(Name ="地址")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Dizhi { get; set; }

       /// <summary>
       ///小区
       /// </summary>
       [Display(Name ="小区")]
       [MaxLength(150)]
       [Column(TypeName="nvarchar(150)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Xiaoqu { get; set; }

       /// <summary>
       ///厂家
       /// </summary>
       [Display(Name ="厂家")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Changjia { get; set; }

       /// <summary>
       ///接收人员
       /// </summary>
       [Display(Name ="接收人员")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Jieshour { get; set; }

       /// <summary>
       ///频次
       /// </summary>
       [Display(Name ="频次")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Pingci { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime Chuangtime { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Chuangjr { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Zhuangtai { get; set; }

       /// <summary>
       ///操作
       /// </summary>
       [Display(Name ="操作")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Caozuo { get; set; }

       
    }
}