<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/model/rcjbb/Bbzx_Rcjbb.js此处编写
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
    import extend from "@/extension/model/rcjbb/Bbzx_Rcjbb.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'id',
                footer: "Foots",
                cnName: '人才机报表',
                name: 'rcjbb/Bbzx_Rcjbb',
                url: "/Bbzx_Rcjbb/",
                sortName: "id"
            });
            const editFormFields = ref({"Xiangmum":"","XiangmuName":"","GongcName":"","Guanligshu":"","DiZhi":"","Hetongmoney":"","Fukuanyn":"","Shoukuanyn":"","Yanshoutime":"","Chuangtime":"","Chuangjr":""});
            const editFormOptions = ref([[{"title":"项目编码","required":true,"field":"Xiangmum"},
                               {"title":"项目名称","required":true,"field":"XiangmuName"}],
                              [{"title":"工程名称","required":true,"field":"GongcName"},
                               {"title":"管理归属","required":true,"field":"Guanligshu"}],
                              [{"title":"地址","required":true,"field":"DiZhi"}],
                              [{"title":"合同金额","required":true,"field":"Hetongmoney","type":"number"},
                               {"title":"付款情况","required":true,"field":"Fukuanyn"},
                               {"title":"收款情况","required":true,"field":"Shoukuanyn"}],
                              [{"title":"验收时间","required":true,"field":"Yanshoutime","type":"datetime"}],
                              [{"title":"创建时间","required":true,"field":"Chuangtime","type":"datetime"},
                               {"title":"创建人员","required":true,"field":"Chuangjr"}]]);
            const searchFormFields = ref({"Xiangmum":"","XiangmuName":"","GongcName":"","DiZhi":"","Guanligshu":"","Hetongmoney":"","Yanshoutime":"","Fukuanyn":"","Shoukuanyn":"","Chuangtime":"","Chuangjr":""});
            const searchFormOptions = ref([[{"title":"项目编码","field":"Xiangmum","type":"like"},{"title":"项目名称","field":"XiangmuName","type":"like"}],[{"title":"工程名称","field":"GongcName","type":"like"},{"title":"管理归属","field":"Guanligshu","type":"like"}],[{"title":"地址","field":"DiZhi","type":"like"}],[{"title":"合同金额","field":"Hetongmoney","type":"like"},{"title":"付款情况","field":"Fukuanyn","type":"like"},{"title":"收款情况","field":"Shoukuanyn","type":"like"}],[{"title":"验收时间","field":"Yanshoutime","type":"like"}],[{"title":"创建时间","field":"Chuangtime","type":"like"},{"title":"创建人员","field":"Chuangjr","type":"like"}]]);
            const columns = ref([{field:'id',title:'id',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Xiangmum',title:'项目编码',type:'string',width:110,require:true,align:'left',sort:true},
                       {field:'XiangmuName',title:'项目名称',type:'string',width:110,require:true,align:'left'},
                       {field:'GongcName',title:'工程名称',type:'string',width:110,require:true,align:'left'},
                       {field:'DiZhi',title:'地址',type:'string',width:110,require:true,align:'left'},
                       {field:'Guanligshu',title:'管理归属',type:'string',width:110,require:true,align:'left'},
                       {field:'Hetongmoney',title:'合同金额',type:'int',width:110,require:true,align:'left'},
                       {field:'Yanshoutime',title:'验收时间',type:'datetime',width:150,require:true,align:'left',sort:true},
                       {field:'Fukuanyn',title:'付款情况',type:'string',width:110,require:true,align:'left'},
                       {field:'Shoukuanyn',title:'收款情况',type:'string',width:110,require:true,align:'left'},
                       {field:'Chuangtime',title:'创建时间',type:'datetime',width:150,require:true,align:'left',sort:true},
                       {field:'Chuangjr',title:'创建人员',type:'string',width:110,require:true,align:'left'}]);
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
