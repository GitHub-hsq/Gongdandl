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
    [Entity(TableCnName = "上报工单",TableName = "Xmugl_Shangbaogd")]
    public partial class Xmugl_Shangbaogd:BaseEntity
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
       ///工程类型
       /// </summary>
       [Display(Name ="工程类型")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Gongcleix { get; set; }

       /// <summary>
       ///项目编码
       /// </summary>
       [Display(Name ="项目编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Xiangmum { get; set; }

       /// <summary>
       ///工程名称
       /// </summary>
       [Display(Name ="工程名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string XiangmuName { get; set; }

       /// <summary>
       ///报案号
       /// </summary>
       [Display(Name ="报案号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Baoanhao { get; set; }

       /// <summary>
       ///工程地点
       /// </summary>
       [Display(Name ="工程地点")]
       [MaxLength(150)]
       [Column(TypeName="nvarchar(150)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string GongcDid { get; set; }

       /// <summary>
       ///管径
       /// </summary>
       [Display(Name ="管径")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Guanjing { get; set; }

       /// <summary>
       ///工程内容
       /// </summary>
       [Display(Name ="工程内容")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Gongcnr { get; set; }

       /// <summary>
       ///到达现场时间
       /// </summary>
       [Display(Name ="到达现场时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime Daodtime { get; set; }

       /// <summary>
       ///完成时间
       /// </summary>
       [Display(Name ="完成时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime Wanctime { get; set; }

       /// <summary>
       ///现场施工人员
       /// </summary>
       [Display(Name ="现场施工人员")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Xcshigongry { get; set; }

       /// <summary>
       ///上报时间
       /// </summary>
       [Display(Name ="上报时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime Shangbaotime { get; set; }

       /// <summary>
       ///上报人员
       /// </summary>
       [Display(Name ="上报人员")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Shangbaor { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Zhaungtai { get; set; }

       
    }
}