
let viewgird = [
  {
    path: '/Sys_Log',
    name: 'sys_Log',
    component: () => import('@/views/system/Sys_Log.vue')
  },
  {
    path: '/Sys_User',
    name: 'Sys_User',
    component: () => import('@/views/system/Sys_User.vue')
  },
  {
    path: '/permission',
    name: 'permission',
    component: () => import('@/views/system/Permission.vue')
  },

  {
    path: '/Sys_Dictionary',
    name: 'Sys_Dictionary',
    component: () => import('@/views/system/Sys_Dictionary.vue')
  },
  {
    path: '/Sys_Role',
    name: 'Sys_Role',
    component: () => import('@/views/system/Sys_Role.vue')
  }, {
    path: '/Sys_Role1',
    name: 'Sys_Role1',
    component: () => import('@/views/system/Sys_Role1.vue')
  }
  , {
    path: '/Sys_DictionaryList',
    name: 'Sys_DictionaryList',
    component: () => import('@/views/system/Sys_DictionaryList.vue')
  }, {
    path: '/FormDesignOptions',
    name: 'FormDesignOptions',
    component: () => import('@/views/system/form/FormDesignOptions.vue')
  }, {
    path: '/FormCollectionObject',
    name: 'FormCollectionObject',
    component: () => import('@/views/system/form/FormCollectionObject.vue')
  }, {
    path: '/Sys_WorkFlow',
    name: 'Sys_WorkFlow',
    component: () => import('@/views/system/flow/Sys_WorkFlow.vue')
  }, {
    path: '/Sys_WorkFlowTable',
    name: 'Sys_WorkFlowTable',
    component: () => import('@/views/system/flow/Sys_WorkFlowTable.vue')
  }, {
    path: '/Sys_QuartzOptions',
    name: 'Sys_QuartzOptions',
    component: () => import('@/views/system/quartz/Sys_QuartzOptions.vue')
  }, {
    path: '/Sys_QuartzLog',
    name: 'Sys_QuartzLog',
    component: () => import('@/views/system/quartz/Sys_QuartzLog.vue')
  }, {
    path: '/Sys_Department',
    name: 'Sys_Department',
    component: () => import('@/views/system/system/Sys_Department.vue')
  }    ,{
        path: '/Jczl_Gsgl',
        name: 'Jczl_Gsgl',
        component: () => import('@/views/model/gsgl/Jczl_Gsgl.vue')
    }    ,{
        path: '/Xmugl_Xmulb',
        name: 'Xmugl_Xmulb',
        component: () => import('@/views/model/xmulb0/Xmugl_Xmulb.vue')
    }    ,{
        path: '/Jczl_Rygl',
        name: 'Jczl_Rygl',
        component: () => import('@/views/model/rygl/Jczl_Rygl.vue')
    }    ,{
        path: '/Jczl_WLgl',
        name: 'Jczl_WLgl',
        component: () => import('@/views/wlgl/wlgl/Jczl_WLgl.vue')
    }    ,{
        path: '/Ccgl_Wlrk',
        name: 'Ccgl_Wlrk',
        component: () => import('@/views/ccgl/wlrk/Ccgl_Wlrk.vue')
    }    ,{
        path: '/Ccgl_WLcku',
        name: 'Ccgl_WLcku',
        component: () => import('@/views/model/wlcku/Ccgl_WLcku.vue')
    }    ,{
        path: '/Bbzx_Sskc0',
        name: 'Bbzx_Sskc0',
        component: () => import('@/views/model/sskc0/Bbzx_Sskc0.vue')
    }    ,{
        path: '/Bbzx_WLluli',
        name: 'Bbzx_WLluli',
        component: () => import('@/views/model/wlluli/Bbzx_WLluli.vue')
    }    ,{
        path: '/Bbzx_Rcjbb',
        name: 'Bbzx_Rcjbb',
        component: () => import('@/views/rcjbb/rcjbb/Bbzx_Rcjbb.vue')
    }    ,{
        path: '/Xmugl_Shangbaogd',
        name: 'Xmugl_Shangbaogd',
        component: () => import('@/views/model/shangbaogd/Xmugl_Shangbaogd.vue')
    }    ,{
        path: '/Gdgl_Pfgd',
        name: 'Gdgl_Pfgd',
        component: () => import('@/views/model/pfgd/Gdgl_Pfgd.vue')
    }    ,{
        path: '/Gdgl_Xjrb',
        name: 'Gdgl_Xjrb',
        component: () => import('@/views/model/xjrb/Gdgl_Xjrb.vue')
    }    ,{
        path: '/Gdgl_Jhgl',
        name: 'Gdgl_Jhgl',
        component: () => import('@/views/model/jhgl/Gdgl_Jhgl.vue')
    }    ,{
        path: '/Ccgl_WLrku',
        name: 'Ccgl_WLrku',
        component: () => import('@/views/model/wlrku/Ccgl_WLrku.vue')
    }    ,{
        path: '/Ccgl_Jxtz',
        name: 'Ccgl_Jxtz',
        component: () => import('@/views/model/jxtz/Ccgl_Jxtz.vue')
    }    ,{
        path: '/Jczl_Bfgl',
        name: 'Jczl_Bfgl',
        component: () => import('@/views/model/bfgl/Jczl_Bfgl.vue')
    }    ,{
        path: '/Xmugl_Xmub',
        name: 'Xmugl_Xmub',
        component: () => import('@/views/model/xmub/Xmugl_Xmub.vue')
    }]

export default viewgird
