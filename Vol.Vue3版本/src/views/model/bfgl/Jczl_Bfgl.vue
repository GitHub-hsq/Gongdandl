<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/model/bfgl/Jczl_Bfgl.js此处编写
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
    import extend from "@/extension/model/bfgl/Jczl_Bfgl.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'id',
                footer: "Foots",
                cnName: '泵房管理',
                name: 'bfgl/Jczl_Bfgl',
                url: "/Jczl_Bfgl/",
                sortName: "Chuangtime"
            });
            const editFormFields = ref({"Xiaoqu":"","Xiaoqudz":"","Wyname":"","Shufgs":[],"Shugxs":"","Chuangjr":[],"Chuangtime":""});
            const editFormOptions = ref([[{"title":"小区","required":true,"field":"Xiaoqu"},
                               {"title":"小区地址","required":true,"field":"Xiaoqudz"}],
                              [{"title":"物业名称","required":true,"field":"Wyname"},
                               {"dataKey":"公司管理","data":[],"title":"所属分公司","required":true,"field":"Shufgs","type":"cascader"},
                               {"title":"所属管线所","required":true,"field":"Shugxs"}],
                              [{"dataKey":"人员管理","data":[],"title":"创建人员","required":true,"field":"Chuangjr","type":"cascader"},
                               {"title":"创建时间","required":true,"field":"Chuangtime","type":"datetime"}]]);
            const searchFormFields = ref({"Xiaoqu":"","Xiaoqudz":"","Wyname":"","Shufgs":[],"Shugxs":"","Chuangjr":[],"Chuangtime":""});
            const searchFormOptions = ref([[{"title":"小区","field":"Xiaoqu","type":"like"},{"title":"小区地址","field":"Xiaoqudz","type":"like"}],[{"title":"物业名称","field":"Wyname","type":"like"},{"dataKey":"公司管理","data":[],"title":"所属分公司","field":"Shufgs","type":"cascader"},{"title":"所属管线所","field":"Shugxs","type":"like"}],[{"dataKey":"人员管理","data":[],"title":"创建人员","field":"Chuangjr","type":"cascader"},{"title":"创建时间","field":"Chuangtime","type":"datetime"}]]);
            const columns = ref([{field:'id',title:'id',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Xiaoqu',title:'小区',type:'string',width:110,require:true,align:'left',sort:true},
                       {field:'Xiaoqudz',title:'小区地址',type:'string',width:180,require:true,align:'left'},
                       {field:'Wyname',title:'物业名称',type:'string',width:110,require:true,align:'left'},
                       {field:'Shufgs',title:'所属分公司',type:'string',bind:{ key:'公司管理',data:[]},width:110,require:true,align:'left'},
                       {field:'Shugxs',title:'所属管线所',type:'string',width:110,require:true,align:'left'},
                       {field:'Chuangjr',title:'创建人员',type:'string',bind:{ key:'人员管理',data:[]},width:110,require:true,align:'left'},
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
