<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/model/pfgd/Gdgl_Pfgd.js此处编写
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
    import extend from "@/extension/model/pfgd/Gdgl_Pfgd.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'id',
                footer: "Foots",
                cnName: '派发工单',
                name: 'pfgd/Gdgl_Pfgd',
                url: "/Gdgl_Pfgd/",
                sortName: "Riqi"
            });
            const editFormFields = ref({"Xiangmum":"","Renwdbianhao":"","Dizhi":"","Guanlguishu":"","Riqi":"","Daodtime":"","Xiufutime":"","Haocaimx":"","Renwuneir":"","Feiyong":"","Chuchu":"","Zhuangtai":""});
            const editFormOptions = ref([[{"title":"项目编码","required":true,"field":"Xiangmum"},
                               {"title":"任务单编号","required":true,"field":"Renwdbianhao"}],
                              [{"title":"地址","required":true,"field":"Dizhi"},
                               {"title":"管理归属","required":true,"field":"Guanlguishu"}],
                              [{"title":"日期","required":true,"field":"Riqi","type":"month"},
                               {"title":"到达时间","required":true,"field":"Daodtime","type":"time"},
                               {"title":"修复时间","required":true,"field":"Xiufutime","type":"time"}],
                              [{"title":"耗材明细","required":true,"field":"Haocaimx"},
                               {"title":"任务内容","required":true,"field":"Renwuneir"},
                               {"title":"费用 ( 元 )","required":true,"field":"Feiyong","type":"decimal"}],
                              [{"title":"出处","required":true,"field":"Chuchu"},
                               {"title":"状态","required":true,"field":"Zhuangtai"}]]);
            const searchFormFields = ref({"Xiangmum":"","Riqi":"","Dizhi":"","Guanlguishu":"","Daodtime":"","Xiufutime":"","Haocaimx":"","Renwdbianhao":"","Renwuneir":"","Feiyong":"","Chuchu":"","Zhuangtai":""});
            const searchFormOptions = ref([[{"title":"项目编码","field":"Xiangmum"},{"title":"任务单编号","field":"Renwdbianhao"}],[{"title":"地址","field":"Dizhi"},{"title":"管理归属","field":"Guanlguishu"}],[{"title":"日期","field":"Riqi"},{"title":"到达时间","field":"Daodtime"},{"title":"修复时间","field":"Xiufutime"}],[{"title":"耗材明细","field":"Haocaimx"},{"title":"任务内容","field":"Renwuneir"},{"title":"费用 ( 元 )","field":"Feiyong","type":"decimal"}],[{"title":"出处","field":"Chuchu"},{"title":"状态","field":"Zhuangtai"}]]);
            const columns = ref([{field:'id',title:'id',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Xiangmum',title:'项目编码',type:'string',width:110,require:true,align:'left',sort:true},
                       {field:'Riqi',title:'日期',type:'datetime',width:150,require:true,align:'left',sort:true},
                       {field:'Dizhi',title:'地址',type:'string',width:180,require:true,align:'left'},
                       {field:'Guanlguishu',title:'管理归属',type:'string',width:110,require:true,align:'left'},
                       {field:'Daodtime',title:'到达时间',type:'datetime',width:150,require:true,align:'left',sort:true},
                       {field:'Xiufutime',title:'修复时间',type:'datetime',width:150,require:true,align:'left',sort:true},
                       {field:'Haocaimx',title:'耗材明细',type:'string',width:220,require:true,align:'left'},
                       {field:'Renwdbianhao',title:'任务单编号',type:'string',width:110,require:true,align:'left'},
                       {field:'Renwuneir',title:'任务内容',type:'string',width:220,require:true,align:'left'},
                       {field:'Feiyong',title:'费用 ( 元 )',type:'decimal',width:110,require:true,align:'left'},
                       {field:'Chuchu',title:'出处',type:'string',width:110,require:true,align:'left'},
                       {field:'Zhuangtai',title:'状态',type:'string',width:110,require:true,align:'left'}]);
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
