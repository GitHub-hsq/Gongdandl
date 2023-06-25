<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/model/rygl/Jczl_Rygl.js此处编写
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
    import extend from "@/extension/model/rygl/Jczl_Rygl.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'id',
                footer: "Foots",
                cnName: '人员管理',
                name: 'rygl/Jczl_Rygl',
                url: "/Jczl_Rygl/",
                sortName: "id"
            });
            const editFormFields = ref({"Gsname":[],"Lianxir":"","Lianxifs":"","Beizhu":""});
            const editFormOptions = ref([[{"dataKey":"公司管理","data":[],"title":"公司名称","required":true,"field":"Gsname","type":"cascader"}],
                              [{"title":"联系人","required":true,"field":"Lianxir"},
                               {"title":"联系方式","required":true,"field":"Lianxifs"}],
                              [{"title":"备注","field":"Beizhu"}]]);
            const searchFormFields = ref({"Gsname":[],"Lianxir":"","Lianxifs":"","Beizhu":""});
            const searchFormOptions = ref([[{"dataKey":"公司管理","data":[],"title":"公司名称","field":"Gsname"}],[{"title":"联系人","field":"Lianxir"},{"title":"联系方式","field":"Lianxifs"}],[{"title":"备注","field":"Beizhu"}]]);
            const columns = ref([{field:'id',title:'id',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Gsname',title:'公司名称',type:'string',bind:{ key:'公司管理',data:[]},width:110,require:true,align:'left',sort:true},
                       {field:'Lianxir',title:'联系人',type:'string',width:110,require:true,align:'left'},
                       {field:'Lianxifs',title:'联系方式',type:'string',width:110,require:true,align:'left'},
                       {field:'Beizhu',title:'备注',type:'string',width:110,align:'left'}]);
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
