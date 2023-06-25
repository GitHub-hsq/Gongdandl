<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/model/xjrb/Gdgl_Xjrb.js此处编写
 -->
<template>
    <view-grid ref="grid"
               :columns="columns"
               :detail="detail"
               :editFormFields="editFormFields"
               :editFormOptions="editFormOptions"
               :searchFormFields="searchFormFields"
               :searchFormOptions="searchFormOptions"
               :table="table"
               :extend="extend">
    </view-grid>
</template>
<script>
    import extend from "@/extension/model/xjrb/Gdgl_Xjrb.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'id',
                footer: "Foots",
                cnName: '巡检日报',
                name: 'xjrb/Gdgl_Xjrb',
                url: "/Gdgl_Xjrb/",
                sortName: "Shangbaotime"
            });
            const editFormFields = ref({"Riqi":"","Shangbaotime":"","Dizhi":"","Xiaoqu":"","Pingci":"","Jieshour":[],"Changjia":"","Jiejfangan":"","Xunjqk":"","Xiancimg":"","Feiyong":"","Zhuangtai":""});
            const editFormOptions = ref([[{"title":"日期","required":true,"field":"Riqi","type":"month"},
                               {"title":"上报时间","required":true,"field":"Shangbaotime","type":"datetime"}],
                              [{"title":"地址","required":true,"field":"Dizhi"},
                               {"title":"小区","required":true,"field":"Xiaoqu"},
                               {"title":"频次","required":true,"field":"Pingci"},
                               {"dataKey":"人员管理","data":[],"title":"接受人员","required":true,"field":"Jieshour","type":"cascader"}],
                              [{"title":"厂家","required":true,"field":"Changjia"},
                               {"title":"解决方案","required":true,"field":"Jiejfangan"}],
                              [{"title":"巡检情况","required":true,"field":"Xunjqk"},
                               {"title":"现场照片","required":true,"field":"Xiancimg","type":"img"},
                               {"title":"费用（元）","required":true,"field":"Feiyong","type":"decimal"}],
                              [{"title":"状态","required":true,"field":"Zhuangtai"}]]);
            const searchFormFields = ref({"Riqi":"","Dizhi":"","Xiaoqu":"","Changjia":"","Pingci":"","Jieshour":[],"Shangbaotime":"","Xunjqk":"","Xiancimg":"","Jiejfangan":"","Feiyong":"","Zhuangtai":""});
            const searchFormOptions = ref([[{"title":"日期","field":"Riqi","type":"like"},{"title":"上报时间","field":"Shangbaotime","type":"like"}],[{"title":"地址","field":"Dizhi","type":"like"},{"title":"小区","field":"Xiaoqu","type":"like"},{"title":"频次","field":"Pingci","type":"like"},{"dataKey":"人员管理","data":[],"title":"接受人员","field":"Jieshour","type":"like"}],[{"title":"厂家","field":"Changjia","type":"like"},{"title":"解决方案","field":"Jiejfangan","type":"like"}],[{"title":"巡检情况","field":"Xunjqk","type":"like"},{"title":"现场照片","field":"Xiancimg","type":"like"},{"title":"费用（元）","field":"Feiyong","type":"like"}],[{"title":"状态","field":"Zhuangtai","type":"like"}]]);
            const columns = ref([{field:'id',title:'id',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Riqi',title:'日期',type:'datetime',width:150,require:true,align:'left',sort:true},
                       {field:'Dizhi',title:'地址',type:'string',width:110,require:true,align:'left'},
                       {field:'Xiaoqu',title:'小区',type:'string',width:180,require:true,align:'left'},
                       {field:'Changjia',title:'厂家',type:'string',width:110,require:true,align:'left'},
                       {field:'Pingci',title:'频次',type:'string',width:110,require:true,align:'left'},
                       {field:'Jieshour',title:'接受人员',type:'string',bind:{ key:'人员管理',data:[]},width:110,require:true,align:'left'},
                       {field:'Shangbaotime',title:'上报时间',type:'datetime',width:150,require:true,align:'left',sort:true},
                       {field:'Xunjqk',title:'巡检情况',type:'string',width:110,require:true,align:'left'},
                       {field:'Xiancimg',title:'现场照片',type:'string',width:110,require:true,align:'left'},
                       {field:'Jiejfangan',title:'解决方案',type:'string',width:180,require:true,align:'left'},
                       {field:'Feiyong',title:'费用（元）',type:'decimal',width:110,require:true,align:'left'},
                       {field:'Zhuangtai',title:'状态',type:'string',width:110,require:true,align:'left'}]);
            const detail = ref({
                cnName: "#detailCnName",
                table: "#detailTable",
                columns: [],
                sortName: "",
                key: ""
            });
            return {
                table,
                extend,
                editFormFields,
                editFormOptions,
                searchFormFields,
                searchFormOptions,
                columns,
                detail,
            };
        },
    });
</script>
