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
    [Entity(TableCnName = "项目列表",TableName = "Xmugl_Xmulb")]
    public partial class Xmugl_Xmulb:BaseEntity
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
       ///项目名称
       /// </summary>
       [Display(Name ="项目名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string XiangmuName { get; set; }

       /// <summary>
       ///工程名称
       /// </summary>
       [Display(Name ="工程名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string GongcName { get; set; }

       /// <summary>
       ///地址
       /// </summary>
       [Display(Name ="地址")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string DiZhi { get; set; }

       /// <summary>
       ///归属管理
       /// </summary>
       [Display(Name ="归属管理")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Guanligshu { get; set; }

       /// <summary>
       ///合同金额
       /// </summary>
       [Display(Name ="合同金额")]
       [DisplayFormat(DataFormatString="19,4")]
       [Column(TypeName="money")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Hetongmoney { get; set; }

       /// <summary>
       ///验收时间
       /// </summary>
       [Display(Name ="验收时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime Yanshoutime { get; set; }

       /// <summary>
       ///付款情况
       /// </summary>
       [Display(Name ="付款情况")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Fukuanyn { get; set; }

       /// <summary>
       ///收款情况
       /// </summary>
       [Display(Name ="收款情况")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Shoukuanyn { get; set; }

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

       
    }
}