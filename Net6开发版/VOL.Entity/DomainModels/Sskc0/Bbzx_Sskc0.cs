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
    [Entity(TableCnName = "实际库存",TableName = "Bbzx_Sskc0")]
    public partial class Bbzx_Sskc0:BaseEntity
    {
        /// <summary>
       ///物料编号
       /// </summary>
       [Display(Name ="物料编号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WL_Id { get; set; }

       /// <summary>
       ///物料名称
       /// </summary>
       [Display(Name ="物料名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WLname { get; set; }

       /// <summary>
       ///物料规格
       /// </summary>
       [Display(Name ="物料规格")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WLsize { get; set; }

       /// <summary>
       ///供应商
       /// </summary>
       [Display(Name ="供应商")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WLgys { get; set; }

       /// <summary>
       ///分类
       /// </summary>
       [Display(Name ="分类")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WLfenlei { get; set; }

       /// <summary>
       ///数量
       /// </summary>
       [Display(Name ="数量")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int WLnumber { get; set; }

       /// <summary>
       ///单位
       /// </summary>
       [Display(Name ="单位")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WLdanwei { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int id { get; set; }

       /// <summary>
       ///入库时间
       /// </summary>
       [Display(Name ="入库时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime Rctime { get; set; }

       /// <summary>
       ///入库人
       /// </summary>
       [Display(Name ="入库人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Rukur { get; set; }

       
    }
}