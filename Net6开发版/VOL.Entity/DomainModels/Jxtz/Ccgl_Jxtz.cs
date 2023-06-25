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
    [Entity(TableCnName = "机械台账",TableName = "Ccgl_Jxtz")]
    public partial class Ccgl_Jxtz:BaseEntity
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
       ///机械编码
       /// </summary>
       [Display(Name ="机械编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Jixiema { get; set; }

       /// <summary>
       ///机械名称
       /// </summary>
       [Display(Name ="机械名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Jixiename { get; set; }

       /// <summary>
       ///机械规格
       /// </summary>
       [Display(Name ="机械规格")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Jixiesize { get; set; }

       /// <summary>
       ///借调人
       /// </summary>
       [Display(Name ="借调人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Jiediaor { get; set; }

       /// <summary>
       ///借调时间
       /// </summary>
       [Display(Name ="借调时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime Jiediaotime { get; set; }

       /// <summary>
       ///借调数量
       /// </summary>
       [Display(Name ="借调数量")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Jiediaonumber { get; set; }

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
       ///单位
       /// </summary>
       [Display(Name ="单位")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Danwei { get; set; }

       /// <summary>
       ///相关单据
       /// </summary>
       [Display(Name ="相关单据")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Xianggdj { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(150)]
       [Column(TypeName="nvarchar(150)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Beizhu { get; set; }

       
    }
}