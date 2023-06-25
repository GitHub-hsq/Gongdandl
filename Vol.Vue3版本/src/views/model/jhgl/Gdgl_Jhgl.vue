<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/model/jhgl/Gdgl_Jhgl.js此处编写
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
    import extend from "@/extension/model/jhgl/Gdgl_Jhgl.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'id',
                footer: "Foots",
                cnName: '计划管理',
                name: 'jhgl/Gdgl_Jhgl',
                url: "/Gdgl_Jhgl/",
                sortName: "id"
            });
            const editFormFields = ref({"Dizhi":"","Xiaoqu":"","Jieshour":[],"Kaishiriqi":"","Pingci":"","Chuangtime":"","Chuangjr":[],"Changjia":"","Zhuangtai":"","Caozuo":""});
            const editFormOptions = ref([[{"title":"地址","required":true,"field":"Dizhi"},
                               {"title":"小区","required":true,"field":"Xiaoqu"},
                               {"dataKey":"人员管理","data":[],"title":"接收人员","required":true,"field":"Jieshour","type":"cascader"}],
                              [{"title":"开始日期","required":true,"field":"Kaishiriqi","type":"month"},
                               {"title":"频次","required":true,"field":"Pingci"},
                               {"title":"创建时间","required":true,"field":"Chuangtime","type":"datetime"},
                               {"dataKey":"人员管理","data":[],"title":"创建人","required":true,"field":"Chuangjr","type":"cascader"}],
                              [{"title":"厂家","required":true,"field":"Changjia"},
                               {"title":"状态","required":true,"field":"Zhuangtai"},
                               {"title":"操作","required":true,"field":"Caozuo"}]]);
            const searchFormFields = ref({"Kaishiriqi":"","Dizhi":"","Xiaoqu":"","Changjia":"","Jieshour":[],"Pingci":"","Chuangtime":"","Chuangjr":[],"Zhuangtai":"","Caozuo":""});
            const searchFormOptions = ref([[{"title":"地址","field":"Dizhi"},{"title":"小区","field":"Xiaoqu"},{"dataKey":"人员管理","data":[],"title":"接收人员","field":"Jieshour"}],[{"title":"开始日期","field":"Kaishiriqi"},{"title":"频次","field":"Pingci"},{"title":"创建时间","field":"Chuangtime"},{"dataKey":"人员管理","data":[],"title":"创建人","field":"Chuangjr"}],[{"title":"厂家","field":"Changjia"},{"title":"状态","field":"Zhuangtai"},{"title":"操作","field":"Caozuo"}]]);
            const columns = ref([{field:'id',title:'id',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Kaishiriqi',title:'开始日期',type:'datetime',width:150,require:true,align:'left',sort:true},
                       {field:'Dizhi',title:'地址',type:'string',width:110,require:true,align:'left'},
                       {field:'Xiaoqu',title:'小区',type:'string',width:180,require:true,align:'left'},
                       {field:'Changjia',title:'厂家',type:'string',width:110,require:true,align:'left'},
                       {field:'Jieshour',title:'接收人员',type:'string',bind:{ key:'人员管理',data:[]},width:110,require:true,align:'left'},
                       {field:'Pingci',title:'频次',type:'string',width:110,require:true,align:'left'},
                       {field:'Chuangtime',title:'创建时间',type:'datetime',width:150,require:true,align:'left',sort:true},
                       {field:'Chuangjr',title:'创建人',type:'string',bind:{ key:'人员管理',data:[]},width:110,require:true,align:'left'},
                       {field:'Zhuangtai',title:'状态',type:'string',width:110,require:true,align:'left'},
                       {field:'Caozuo',title:'操作',type:'string',width:110,require:true,align:'left'}]);
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
