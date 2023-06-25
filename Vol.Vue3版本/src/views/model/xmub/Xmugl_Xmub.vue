<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/model/xmub/Xmugl_Xmub.js此处编写
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
    import extend from "@/extension/model/xmub/Xmugl_Xmub.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'id',
                footer: "Foots",
                cnName: '项目列表',
                name: 'xmub/Xmugl_Xmub',
                url: "/Xmugl_Xmub/",
                sortName: "Chuangtime"
            });
            const editFormFields = ref({"Xiangmum":"","XiangmuName":"","GongcName":"","Guanligshu":[],"Hetongmoney":"","DiZhi":"","Yanshoutime":"","Chuangtime":"","Fukuanyn":"","Shoukuanyn":"","Chuangjr":[]});
            const editFormOptions = ref([[{"title":"项目编码","required":true,"field":"Xiangmum"},
                               {"title":"项目名称","required":true,"field":"XiangmuName"}],
                              [{"title":"工程名称","required":true,"field":"GongcName"},
                               {"dataKey":"公司管理","data":[],"title":"归属管理","required":true,"field":"Guanligshu","type":"cascader"},
                               {"title":"合同金额","required":true,"field":"Hetongmoney","type":"number"}],
                              [{"title":"地址","required":true,"field":"DiZhi"}],
                              [{"title":"验收时间","required":true,"field":"Yanshoutime","type":"datetime"},
                               {"title":"创建时间","required":true,"field":"Chuangtime","type":"datetime"}],
                              [{"title":"付款情况","required":true,"field":"Fukuanyn"},
                               {"title":"收款情况","required":true,"field":"Shoukuanyn"}],
                              [{"dataKey":"人员管理","data":[],"title":"创建人","required":true,"field":"Chuangjr","type":"cascader"}]]);
            const searchFormFields = ref({});
            const searchFormOptions = ref([]);
            const columns = ref([{field:'id',title:'id',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Xiangmum',title:'项目编码',type:'string',width:110,require:true,align:'left',sort:true},
                       {field:'XiangmuName',title:'项目名称',type:'string',width:110,require:true,align:'left'},
                       {field:'GongcName',title:'工程名称',type:'string',width:110,require:true,align:'left'},
                       {field:'DiZhi',title:'地址',type:'string',width:110,require:true,align:'left'},
                       {field:'Guanligshu',title:'归属管理',type:'string',bind:{ key:'公司管理',data:[]},width:110,require:true,align:'left'},
                       {field:'Hetongmoney',title:'合同金额',type:'int',width:110,require:true,align:'left'},
                       {field:'Yanshoutime',title:'验收时间',type:'datetime',width:150,require:true,align:'left',sort:true},
                       {field:'Fukuanyn',title:'付款情况',type:'string',width:110,require:true,align:'left'},
                       {field:'Shoukuanyn',title:'收款情况',type:'string',width:110,require:true,align:'left'},
                       {field:'Chuangtime',title:'创建时间',type:'datetime',width:150,require:true,align:'left',sort:true},
                       {field:'Chuangjr',title:'创建人',type:'string',bind:{ key:'人员管理',data:[]},width:110,require:true,align:'left'}]);
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
