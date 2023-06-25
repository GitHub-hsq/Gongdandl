<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/model/wlcku/Ccgl_WLcku.js此处编写
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
    import extend from "@/extension/model/wlcku/Ccgl_WLcku.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'id',
                footer: "Foots",
                cnName: '物料出库',
                name: 'wlcku/Ccgl_WLcku',
                url: "/Ccgl_WLcku/",
                sortName: "id"
            });
            const editFormFields = ref({"Xiangmum":"","WL_Id":"","WLname":"","WLsize":"","Chunumber":"","ChuTime":"","XgDanju":""});
            const editFormOptions = ref([[{"title":"项目编码","required":true,"field":"Xiangmum"},
                               {"title":"物料编码","required":true,"field":"WL_Id"}],
                              [{"title":"物料名称","required":true,"field":"WLname"},
                               {"title":"物料规格","required":true,"field":"WLsize"},
                               {"title":"出库数量","required":true,"field":"Chunumber","type":"number"}],
                              [{"title":"出库时间","required":true,"field":"ChuTime","type":"datetime"}],
                              [{"title":"相关单据","required":true,"field":"XgDanju"}]]);
            const searchFormFields = ref({"Xiangmum":"","WL_Id":"","WLname":"","WLsize":"","Chunumber":"","ChuTime":"","XgDanju":""});
            const searchFormOptions = ref([[{"title":"项目编码","field":"Xiangmum","type":"like"},{"title":"物料编码","field":"WL_Id","type":"like"}],[{"title":"物料名称","field":"WLname","type":"like"},{"title":"物料规格","field":"WLsize","type":"like"},{"title":"出库数量","field":"Chunumber","type":"like"}],[{"title":"出库时间","field":"ChuTime","type":"like"}],[{"title":"相关单据","field":"XgDanju","type":"like"}]]);
            const columns = ref([{field:'id',title:'id',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Xiangmum',title:'项目编码',type:'string',width:110,require:true,align:'left',sort:true},
                       {field:'WL_Id',title:'物料编码',type:'string',width:110,require:true,align:'left'},
                       {field:'WLname',title:'物料名称',type:'string',width:110,require:true,align:'left'},
                       {field:'WLsize',title:'物料规格',type:'string',width:110,require:true,align:'left'},
                       {field:'Chunumber',title:'出库数量',type:'int',width:110,require:true,align:'left'},
                       {field:'ChuTime',title:'出库时间',type:'datetime',width:150,require:true,align:'left',sort:true},
                       {field:'XgDanju',title:'相关单据',type:'string',width:110,require:true,align:'left'}]);
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
