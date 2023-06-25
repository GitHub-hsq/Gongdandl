<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/model/sskc0/Bbzx_Sskc0.js此处编写
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
    import extend from "@/extension/model/sskc0/Bbzx_Sskc0.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'id',
                footer: "Foots",
                cnName: '实际库存',
                name: 'sskc0/Bbzx_Sskc0',
                url: "/Bbzx_Sskc0/",
                sortName: "WLnumber"
            });
            const editFormFields = ref({"WL_Id":"","WLname":"","WLsize":"","WLgys":"","WLfenlei":"","WLnumber":"","WLdanwei":"","Rctime":"","Rukur":""});
            const editFormOptions = ref([[{"title":"物料编号","required":true,"field":"WL_Id"}],
                              [{"title":"物料名称","required":true,"field":"WLname"}],
                              [{"title":"物料规格","required":true,"field":"WLsize"}],
                              [{"title":"供应商","required":true,"field":"WLgys"}],
                              [{"title":"分类","required":true,"field":"WLfenlei"}],
                              [{"title":"数量","required":true,"field":"WLnumber","type":"number"}],
                              [{"title":"单位","required":true,"field":"WLdanwei"}],
                              [{"title":"入库时间","required":true,"field":"Rctime","type":"datetime"},
                               {"title":"入库人","required":true,"field":"Rukur"}]]);
            const searchFormFields = ref({"WL_Id":"","WLname":"","WLsize":"","WLgys":"","WLfenlei":"","WLnumber":"","WLdanwei":""});
            const searchFormOptions = ref([[{"title":"物料编号","field":"WL_Id","type":"like"}],[{"title":"物料名称","field":"WLname","type":"like"}],[{"title":"物料规格","field":"WLsize","type":"like"}],[{"title":"供应商","field":"WLgys","type":"like"}],[{"title":"分类","field":"WLfenlei","type":"like"}],[{"title":"数量","field":"WLnumber","type":"like"}],[{"title":"单位","field":"WLdanwei","type":"like"}]]);
            const columns = ref([{field:'WL_Id',title:'物料编号',type:'string',width:110,require:true,align:'left',sort:true},
                       {field:'WLname',title:'物料名称',type:'string',width:110,require:true,align:'left'},
                       {field:'WLsize',title:'物料规格',type:'string',width:110,require:true,align:'left'},
                       {field:'WLgys',title:'供应商',type:'string',width:110,require:true,align:'left'},
                       {field:'WLfenlei',title:'分类',type:'string',width:110,require:true,align:'left'},
                       {field:'WLnumber',title:'数量',type:'int',width:110,require:true,align:'left'},
                       {field:'WLdanwei',title:'单位',type:'string',width:110,require:true,align:'left'},
                       {field:'id',title:'id',type:'int',sort:true,width:80,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Rctime',title:'入库时间',type:'datetime',width:150,require:true,align:'left',sort:true},
                       {field:'Rukur',title:'入库人',type:'string',width:120,require:true,align:'left'}]);
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
