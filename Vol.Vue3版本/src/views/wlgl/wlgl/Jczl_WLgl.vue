<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/wlgl/wlgl/Jczl_WLgl.js此处编写
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
    import extend from "@/extension/wlgl/wlgl/Jczl_WLgl.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'id',
                footer: "Foots",
                cnName: '物料管理',
                name: 'wlgl/Jczl_WLgl',
                url: "/Jczl_WLgl/",
                sortName: "id"
            });
            const editFormFields = ref({"WL_Id":"","WLname":"","WLsize":"","Danwei":"","Pingpai":"","WLleixing":""});
            const editFormOptions = ref([[{"title":"物料编码","required":true,"field":"WL_Id"},
                               {"title":"物料名称","required":true,"field":"WLname"}],
                              [{"title":"物料规格","required":true,"field":"WLsize"},
                               {"title":"单位","required":true,"field":"Danwei"}],
                              [{"title":"厂牌","required":true,"field":"Pingpai"},
                               {"title":"物料类型","required":true,"field":"WLleixing"}]]);
            const searchFormFields = ref({"WL_Id":"","WLname":"","WLsize":"","Pingpai":"","Danwei":"","WLleixing":""});
            const searchFormOptions = ref([[{"title":"物料编码","field":"WL_Id"},{"title":"物料名称","field":"WLname"}],[{"title":"物料规格","field":"WLsize"},{"title":"物料类型","field":"WLleixing"}],[{"title":"厂牌","field":"Pingpai"},{"title":"单位","field":"Danwei"}]]);
            const columns = ref([{field:'id',title:'id',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'WL_Id',title:'物料编码',type:'string',width:110,require:true,align:'left',sort:true},
                       {field:'WLname',title:'物料名称',type:'string',width:110,require:true,align:'left'},
                       {field:'WLsize',title:'物料规格',type:'string',width:110,require:true,align:'left'},
                       {field:'Pingpai',title:'厂牌',type:'string',width:110,require:true,align:'left'},
                       {field:'Danwei',title:'单位',type:'string',width:110,require:true,align:'left'},
                       {field:'WLleixing',title:'物料类型',type:'string',width:110,require:true,align:'left'}]);
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
