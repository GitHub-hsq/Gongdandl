<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/model/wlluli/Bbzx_WLluli.js此处编写
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
    import extend from "@/extension/model/wlluli/Bbzx_WLluli.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'id',
                footer: "Foots",
                cnName: '物料履历',
                name: 'wlluli/Bbzx_WLluli',
                url: "/Bbzx_WLluli/",
                sortName: "Chuangtime"
            });
            const editFormFields = ref({"jinchu":[],"WL_Id":"","WLname":"","WLsize":"","WLfenlei":"","Xiangmum":"","WLnumber":"","WLdanwei":"","Danju":"","Chuangjr":[],"Chuangtime":""});
            const editFormOptions = ref([[{"dataKey":"物料进出类型","data":[],"title":"进出类型","required":true,"field":"jinchu","type":"cascader"}],
                              [{"title":"物料编码","required":true,"field":"WL_Id"}],
                              [{"title":"物料名称","required":true,"field":"WLname"}],
                              [{"title":"物料规格","required":true,"field":"WLsize"}],
                              [{"title":"物料分类","required":true,"field":"WLfenlei"}],
                              [{"title":"项目编码","required":true,"field":"Xiangmum"}],
                              [{"title":"数量","required":true,"field":"WLnumber","type":"number"}],
                              [{"title":"单位","required":true,"field":"WLdanwei"}],
                              [{"title":"相关单据","required":true,"field":"Danju"}],
                              [{"dataKey":"人员管理","data":[],"title":"创建人","required":true,"field":"Chuangjr","type":"cascader"}],
                              [{"title":"创建时间","required":true,"field":"Chuangtime","type":"datetime"}]]);
            const searchFormFields = ref({});
            const searchFormOptions = ref([]);
            const columns = ref([{field:'id',title:'id',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'jinchu',title:'进出类型',type:'string',bind:{ key:'物料进出类型',data:[]},width:100,require:true,align:'left',sort:true},
                       {field:'WL_Id',title:'物料编码',type:'string',width:110,require:true,align:'left'},
                       {field:'WLname',title:'物料名称',type:'string',width:110,require:true,align:'left'},
                       {field:'WLsize',title:'物料规格',type:'string',width:150,require:true,align:'left'},
                       {field:'WLfenlei',title:'物料分类',type:'string',width:110,require:true,align:'left'},
                       {field:'Xiangmum',title:'项目编码',type:'string',width:110,require:true,align:'left'},
                       {field:'WLnumber',title:'数量',type:'int',width:50,require:true,align:'left'},
                       {field:'WLdanwei',title:'单位',type:'string',width:50,require:true,align:'left'},
                       {field:'Danju',title:'相关单据',type:'string',width:110,require:true,align:'left'},
                       {field:'Chuangjr',title:'创建人',type:'string',bind:{ key:'人员管理',data:[]},width:110,require:true,align:'left'},
                       {field:'Chuangtime',title:'创建时间',type:'datetime',width:150,require:true,align:'left',sort:true}]);
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
