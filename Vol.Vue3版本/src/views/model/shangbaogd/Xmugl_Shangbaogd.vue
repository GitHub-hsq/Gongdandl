<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/model/shangbaogd/Xmugl_Shangbaogd.js此处编写
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
    import extend from "@/extension/model/shangbaogd/Xmugl_Shangbaogd.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'id',
                footer: "Foots",
                cnName: '上报工单',
                name: 'shangbaogd/Xmugl_Shangbaogd',
                url: "/Xmugl_Shangbaogd/",
                sortName: "Shangbaotime"
            });
            const editFormFields = ref({"Gongcleix":"","Xiangmum":"","XiangmuName":"","Gongcnr":"","Baoanhao":"","GongcDid":"","Guanjing":"","Xcshigongry":[],"Daodtime":"","Wanctime":"","Shangbaotime":"","Shangbaor":[],"Zhaungtai":[]});
            const editFormOptions = ref([[{"title":"工程类型","required":true,"field":"Gongcleix"},
                               {"title":"项目编码","required":true,"field":"Xiangmum"},
                               {"title":"工程名称","required":true,"field":"XiangmuName"}],
                              [{"title":"工程内容","required":true,"field":"Gongcnr","colSize":100,"type":"editor"}],
                              [{"title":"报案号","required":true,"field":"Baoanhao"},
                               {"title":"工程地点","required":true,"field":"GongcDid"},
                               {"title":"管径","required":true,"field":"Guanjing"},
                               {"dataKey":"人员管理","data":[],"title":"现场施工人员","required":true,"field":"Xcshigongry","type":"cascader"}],
                              [{"title":"到达现场时间","required":true,"field":"Daodtime","type":"datetime"},
                               {"title":"完成时间","required":true,"field":"Wanctime","type":"datetime"},
                               {"title":"上报时间","required":true,"field":"Shangbaotime","type":"datetime"}],
                              [{"dataKey":"人员管理","data":[],"title":"上报人员","required":true,"field":"Shangbaor","type":"cascader"},
                               {"title":"状态","required":true,"field":"Zhaungtai","type":"cascader"}]]);
            const searchFormFields = ref({"Gongcleix":"","Xiangmum":"","XiangmuName":"","Baoanhao":"","GongcDid":"","Guanjing":"","Gongcnr":"","Daodtime":"","Wanctime":"","Xcshigongry":[],"Shangbaotime":"","Shangbaor":[],"Zhaungtai":[]});
            const searchFormOptions = ref([[{"title":"工程类型","field":"Gongcleix","type":"like"},{"title":"项目编码","field":"Xiangmum","type":"like"}],[{"title":"工程名称","field":"XiangmuName","type":"like"},{"title":"报案号","field":"Baoanhao","type":"like"},{"title":"工程内容","field":"Gongcnr","type":"like"}],[{"title":"工程地点","field":"GongcDid","type":"like"},{"title":"管径","field":"Guanjing","type":"like"},{"dataKey":"人员管理","data":[],"title":"现场施工人员","field":"Xcshigongry","type":"like"}],[{"title":"到达现场时间","field":"Daodtime","type":"like"},{"title":"完成时间","field":"Wanctime","type":"like"},{"title":"上报时间","field":"Shangbaotime","type":"like"}],[{"dataKey":"人员管理","data":[],"title":"上报人员","field":"Shangbaor","type":"like"},{"title":"状态","field":"Zhaungtai","type":"like"}]]);
            const columns = ref([{field:'id',title:'id',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Gongcleix',title:'工程类型',type:'string',width:110,require:true,align:'left',sort:true},
                       {field:'Xiangmum',title:'项目编码',type:'string',width:110,require:true,align:'left'},
                       {field:'XiangmuName',title:'工程名称',type:'string',width:110,require:true,align:'left'},
                       {field:'Baoanhao',title:'报案号',type:'string',width:110,require:true,align:'left'},
                       {field:'GongcDid',title:'工程地点',type:'string',width:180,require:true,align:'left'},
                       {field:'Guanjing',title:'管径',type:'string',width:110,require:true,align:'left'},
                       {field:'Gongcnr',title:'工程内容',type:'string',width:100,require:true,align:'left'},
                       {field:'Daodtime',title:'到达现场时间',type:'datetime',width:150,require:true,align:'left',sort:true},
                       {field:'Wanctime',title:'完成时间',type:'datetime',width:150,require:true,align:'left',sort:true},
                       {field:'Xcshigongry',title:'现场施工人员',type:'string',bind:{ key:'人员管理',data:[]},width:110,require:true,align:'left'},
                       {field:'Shangbaotime',title:'上报时间',type:'datetime',width:150,require:true,align:'left',sort:true},
                       {field:'Shangbaor',title:'上报人员',type:'string',bind:{ key:'人员管理',data:[]},width:110,require:true,align:'left'},
                       {field:'Zhaungtai',title:'状态',type:'string',width:110,require:true,align:'left'}]);
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
