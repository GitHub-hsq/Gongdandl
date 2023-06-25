<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/model/wlrku/Ccgl_WLrku.js此处编写
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
    import extend from "@/extension/model/wlrku/Ccgl_WLrku.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'id',
                footer: "Foots",
                cnName: '物料入库',
                name: 'wlrku/Ccgl_WLrku',
                url: "/Ccgl_WLrku/",
                sortName: "id"
            });
            const editFormFields = ref({"Danjuma":"","Chuangjr":[],"Chuangtime":"","Beizhu":""});
            const editFormOptions = ref([[{"title":"单据编码","field":"Danjuma"}],
                              [{"dataKey":"人员管理","data":[],"title":"创建人","field":"Chuangjr","type":"cascader"}],
                              [{"title":"创建时间","required":true,"field":"Chuangtime","type":"datetime"}],
                              [{"title":"备注","field":"Beizhu"}]]);
            const searchFormFields = ref({"Danjuma":"","Chuangjr":[],"Chuangtime":"","Beizhu":""});
            const searchFormOptions = ref([[{"title":"单据编码","field":"Danjuma","type":"like"}],[{"dataKey":"人员管理","data":[],"title":"创建人","field":"Chuangjr","type":"like"}],[{"title":"创建时间","field":"Chuangtime","type":"datetime"}],[{"title":"备注","field":"Beizhu","type":"like"}]]);
            const columns = ref([{field:'id',title:'id',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Danjuma',title:'单据编码',type:'string',width:110,align:'left',sort:true},
                       {field:'Chuangjr',title:'创建人',type:'string',bind:{ key:'人员管理',data:[]},width:110,align:'left'},
                       {field:'Chuangtime',title:'创建时间',type:'datetime',width:150,require:true,align:'left',sort:true},
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
