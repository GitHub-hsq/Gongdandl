<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/model/gsgl/Jczl_Gsgl.js此处编写
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
    import extend from "@/extension/model/gsgl/Jczl_Gsgl.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'id',
                footer: "Foots",
                cnName: '公司管理',
                name: 'gsgl/Jczl_Gsgl',
                url: "/Jczl_Gsgl/",
                sortName: "id"
            });
            const editFormFields = ref({"GsName":"","Lianxir":"","Lianxifs":"","Beizhu":""});
            const editFormOptions = ref([[{"title":"公司名称","required":true,"field":"GsName"}],
                              [{"title":"联系人","required":true,"field":"Lianxir"}],
                              [{"title":"联系方式","required":true,"field":"Lianxifs"}],
                              [{"title":"备注","field":"Beizhu"}]]);
            const searchFormFields = ref({"GsName":"","Lianxir":"","Lianxifs":"","Beizhu":""});
            const searchFormOptions = ref([[{"title":"公司名称","field":"GsName","type":"like"}],[{"title":"联系人","field":"Lianxir","type":"like"}],[{"title":"联系方式","field":"Lianxifs","type":"like"}],[{"title":"备注","field":"Beizhu","type":"like"}]]);
            const columns = ref([{field:'id',title:'id',type:'int',sort:true,width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'GsName',title:'公司名称',type:'string',width:110,require:true,align:'left',sort:true},
                       {field:'Lianxir',title:'联系人',type:'string',width:110,require:true,align:'left'},
                       {field:'Lianxifs',title:'联系方式',type:'string',width:110,require:true,align:'left'},
                       {field:'Beizhu',title:'备注',type:'string',width:180,align:'left'}]);
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
