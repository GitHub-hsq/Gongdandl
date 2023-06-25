<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/model/jxtz/Ccgl_Jxtz.js此处编写
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
    import extend from "@/extension/model/jxtz/Ccgl_Jxtz.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'id',
                footer: "Foots",
                cnName: '机械台账',
                name: 'jxtz/Ccgl_Jxtz',
                url: "/Ccgl_Jxtz/",
                sortName: "Jiediaotime"
            });
            const editFormFields = ref({"Jixiema":"","Jixiename":"","Jixiesize":"","Jiediaonumber":"","Xiangmum":"","Danwei":"","Jiediaor":[],"Jiediaotime":"","Xianggdj":"","Beizhu":""});
            const editFormOptions = ref([[{"title":"机械编码","required":true,"field":"Jixiema"},
                               {"title":"机械名称","required":true,"field":"Jixiename"}],
                              [{"title":"机械规格","required":true,"field":"Jixiesize"},
                               {"title":"借调数量","required":true,"field":"Jiediaonumber","type":"number"},
                               {"title":"项目编码","required":true,"field":"Xiangmum"},
                               {"title":"单位","required":true,"field":"Danwei"}],
                              [{"dataKey":"人员管理","data":[],"title":"借调人","required":true,"field":"Jiediaor","type":"cascader"},
                               {"title":"借调时间","required":true,"field":"Jiediaotime","type":"datetime"},
                               {"title":"相关单据","required":true,"field":"Xianggdj"}],
                              [{"title":"备注","required":true,"field":"Beizhu"}]]);
            const searchFormFields = ref({"Jixiema":"","Jixiename":"","Jixiesize":"","Jiediaor":[],"Jiediaotime":"","Jiediaonumber":"","Xiangmum":"","Danwei":"","Xianggdj":"","Beizhu":""});
            const searchFormOptions = ref([[{"title":"机械编码","field":"Jixiema","type":"like"},{"title":"机械名称","field":"Jixiename","type":"like"}],[{"title":"机械规格","field":"Jixiesize","type":"like"},{"title":"借调数量","field":"Jiediaonumber","type":"number"},{"title":"项目编码","field":"Xiangmum","type":"like"},{"title":"单位","field":"Danwei","type":"like"}],[{"dataKey":"人员管理","data":[],"title":"借调人","field":"Jiediaor","type":"cascader"},{"title":"借调时间","field":"Jiediaotime","type":"datetime"},{"title":"相关单据","field":"Xianggdj","type":"like"}],[{"title":"备注","field":"Beizhu","type":"like"}]]);
            const columns = ref([{field:'id',title:'id',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Jixiema',title:'机械编码',type:'string',width:110,require:true,align:'left',sort:true},
                       {field:'Jixiename',title:'机械名称',type:'string',width:110,require:true,align:'left'},
                       {field:'Jixiesize',title:'机械规格',type:'string',width:110,require:true,align:'left'},
                       {field:'Jiediaor',title:'借调人',type:'string',bind:{ key:'人员管理',data:[]},width:110,require:true,align:'left'},
                       {field:'Jiediaotime',title:'借调时间',type:'datetime',width:150,require:true,align:'left',sort:true},
                       {field:'Jiediaonumber',title:'借调数量',type:'int',width:110,require:true,align:'left'},
                       {field:'Xiangmum',title:'项目编码',type:'string',width:110,require:true,align:'left'},
                       {field:'Danwei',title:'单位',type:'string',width:110,require:true,align:'left'},
                       {field:'Xianggdj',title:'相关单据',type:'string',width:110,require:true,align:'left'},
                       {field:'Beizhu',title:'备注',type:'string',width:180,require:true,align:'left'}]);
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
