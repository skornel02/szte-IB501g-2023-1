import{s as q,n as z}from"../chunks/scheduler.e108d1fd.js";import{S as F,i as O,g as _,s as x,r as w,h as v,j as k,y as P,c as E,u as b,f,k as y,l as R,a as S,x as u,v as L,d as D,t as j,w as C}from"../chunks/index.786a472e.js";import{b as T}from"../chunks/paths.6cc668bd.js";import{L as U}from"../chunks/LoginForm.f27a21b6.js";import{L as V,a as H,U as J,E as A}from"../chunks/general.e43fa177.js";function M(p){let e,r,s,o,l="Oktatói belépés",m,a,d,n,g,c,h;return a=new U({props:{regUrl:`${T}/kozos/regisztracio`,loginHandler:p[0]}}),n=new V({}),c=new H({}),{c(){e=_("div"),r=_("div"),s=_("div"),o=_("h4"),o.textContent=l,m=x(),w(a.$$.fragment),d=x(),w(n.$$.fragment),g=x(),w(c.$$.fragment),this.h()},l(t){e=v(t,"DIV",{class:!0});var i=k(e);r=v(i,"DIV",{class:!0,style:!0});var I=k(r);s=v(I,"DIV",{class:!0});var $=k(s);o=v($,"H4",{class:!0,"data-svelte-h":!0}),P(o)!=="svelte-1khjtg7"&&(o.textContent=l),m=E($),b(a.$$.fragment,$),$.forEach(f),I.forEach(f),d=E(i),b(n.$$.fragment,i),i.forEach(f),g=E(t),b(c.$$.fragment,t),this.h()},h(){y(o,"class","card-title"),y(s,"class","card-body svelte-1uctxqa"),y(r,"class","card svelte-1uctxqa"),R(r,"width","20rem"),y(e,"class","container logo-container svelte-1uctxqa")},m(t,i){S(t,e,i),u(e,r),u(r,s),u(s,o),u(s,m),L(a,s,null),u(e,d),L(n,e,null),S(t,g,i),L(c,t,i),h=!0},p:z,i(t){h||(D(a.$$.fragment,t),D(n.$$.fragment,t),D(c.$$.fragment,t),h=!0)},o(t){j(a.$$.fragment,t),j(n.$$.fragment,t),j(c.$$.fragment,t),h=!1},d(t){t&&(f(e),f(g)),C(a),C(n),C(c,t)}}}function N(p,e,r){let{data:s}=e;const o=async l=>{const m={...l,userType:J.Teacher};try{const a=await fetch("/api/check-auth",{method:"POST",body:JSON.stringify(m),headers:{"Content-Type":"application/json"}});if(a.status===204)window.location.href=`${T}/oktato/kezdolap`;else{const d=await a.json(),n=await A.safeParseAsync(d);return n.success?n.data.errorMessage:"Ismeretlen hiba történt!"}}catch(a){return console.error(a),"Ismeretlen hálózati hiba történt!"}};return p.$$set=l=>{"data"in l&&r(1,s=l.data)},[o,s]}class X extends F{constructor(e){super(),O(this,e,N,M,q,{data:1})}}export{X as component};