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
    [Entity(TableCnName = "派发工单",TableName = "Gdgl_Pfgd")]
    public partial class Gdgl_Pfgd:BaseEntity
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
       ///项目编码
       /// </summary>
       [Display(Name ="项目编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Xiangmum { get; set; }

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
       [MaxLength(150)]
       [Column(TypeName="nvarchar(150)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Dizhi { get; set; }

       /// <summary>
       ///管理归属
       /// </summary>
       [Display(Name ="管理归属")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Guanlguishu { get; set; }

       /// <summary>
       ///到达时间
       /// </summary>
       [Display(Name ="到达时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime Daodtime { get; set; }

       /// <summary>
       ///修复时间
       /// </summary>
       [Display(Name ="修复时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime Xiufutime { get; set; }

       /// <summary>
       ///耗材明细
       /// </summary>
       [Display(Name ="耗材明细")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Haocaimx { get; set; }

       /// <summary>
       ///任务单编号
       /// </summary>
       [Display(Name ="任务单编号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Renwdbianhao { get; set; }

       /// <summary>
       ///任务内容
       /// </summary>
       [Display(Name ="任务内容")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Renwuneir { get; set; }

       /// <summary>
       ///费用 ( 元 )
       /// </summary>
       [Display(Name ="费用 ( 元 )")]
       [DisplayFormat(DataFormatString="19,4")]
       [Column(TypeName="money")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal Feiyong { get; set; }

       /// <summary>
       ///出处
       /// </summary>
       [Display(Name ="出处")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Chuchu { get; set; }

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