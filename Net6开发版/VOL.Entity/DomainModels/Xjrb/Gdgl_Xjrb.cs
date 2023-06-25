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
    [Entity(TableCnName = "巡检日报",TableName = "Gdgl_Xjrb")]
    public partial class Gdgl_Xjrb:BaseEntity
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
       ///日期
       /// </summary>
       [Display(Name ="日期")]
       [Column(TypeName="date")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime Riqi { get; set; }

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
       ///频次
       /// </summary>
       [Display(Name ="频次")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Pingci { get; set; }

       /// <summary>
       ///接受人员
       /// </summary>
       [Display(Name ="接受人员")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Jieshour { get; set; }

       /// <summary>
       ///上报时间
       /// </summary>
       [Display(Name ="上报时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime Shangbaotime { get; set; }

       /// <summary>
       ///巡检情况
       /// </summary>
       [Display(Name ="巡检情况")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Xunjqk { get; set; }

       /// <summary>
       ///现场照片
       /// </summary>
       [Display(Name ="现场照片")]
       [MaxLength(16)]
       [Column(TypeName="image(16)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Xiancimg { get; set; }

       /// <summary>
       ///解决方案
       /// </summary>
       [Display(Name ="解决方案")]
       [MaxLength(150)]
       [Column(TypeName="nvarchar(150)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Jiejfangan { get; set; }

       /// <summary>
       ///费用（元）
       /// </summary>
       [Display(Name ="费用（元）")]
       [DisplayFormat(DataFormatString="19,4")]
       [Column(TypeName="money")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal Feiyong { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Zhuangtai { get; set; }

       
    }
}