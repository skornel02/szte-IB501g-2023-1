import{s as q,f as $,a as x,g as _,h as w,L as R,c as L,d as p,j as v,k as F,i as j,x as f,C as O,o as P}from"../chunks/scheduler.21bd8612.js";import{S as U,i as V,b,d as D,m as E,a as T,t as A,e as I}from"../chunks/index.2510bc2d.js";import{b as u}from"../chunks/paths.cbaa310c.js";import{L as H,A as J}from"../chunks/AuthResponse.e15510ef.js";import{L as M,a as B}from"../chunks/LoginLogo.bce037a4.js";import{a as C}from"../chunks/js.cookie.edb2da2a.js";import{U as G}from"../chunks/usertypes.d012f79a.js";import{E as N}from"../chunks/ErrorResponseDto.3330ec0e.js";import{g as z}from"../chunks/navigation.53551334.js";function K(y){let a,o,t,s,n="Oktatói belépés",i,r,k,l,d,m,g;return r=new H({props:{regUrl:`${u}/kozos/regisztracio`,loginHandler:y[0]}}),l=new M({}),m=new B({}),{c(){a=$("div"),o=$("div"),t=$("div"),s=$("h4"),s.textContent=n,i=x(),b(r.$$.fragment),k=x(),b(l.$$.fragment),d=x(),b(m.$$.fragment),this.h()},l(e){a=_(e,"DIV",{class:!0});var c=w(a);o=_(c,"DIV",{class:!0,style:!0});var S=w(o);t=_(S,"DIV",{class:!0});var h=w(t);s=_(h,"H4",{class:!0,"data-svelte-h":!0}),R(s)!=="svelte-1khjtg7"&&(s.textContent=n),i=L(h),D(r.$$.fragment,h),h.forEach(p),S.forEach(p),k=L(c),D(l.$$.fragment,c),c.forEach(p),d=L(e),D(m.$$.fragment,e),this.h()},h(){v(s,"class","card-title"),v(t,"class","card-body svelte-1uctxqa"),v(o,"class","card svelte-1uctxqa"),F(o,"width","20rem"),v(a,"class","container logo-container svelte-1uctxqa")},m(e,c){j(e,a,c),f(a,o),f(o,t),f(t,s),f(t,i),E(r,t,null),f(a,k),E(l,a,null),j(e,d,c),E(m,e,c),g=!0},p:O,i(e){g||(T(r.$$.fragment,e),T(l.$$.fragment,e),T(m.$$.fragment,e),g=!0)},o(e){A(r.$$.fragment,e),A(l.$$.fragment,e),A(m.$$.fragment,e),g=!1},d(e){e&&(p(a),p(d)),I(r),I(l),I(m,e)}}}function Q(y){const a=async t=>{const s={...t,userType:G.Teacher};try{const n=await fetch(u+"/api/auth",{method:"POST",body:JSON.stringify(s),headers:{"Content-Type":"application/json"}});if(n.status===200){const i=await J.parseAsync(await n.json()),r=new Date(new Date().getTime()+i.expiresIn*1e3);C.set("oktato-token",i.accessToken,{expires:r,path:"/",secure:!0,sameSite:"strict"}),await z(`${u}/oktato/kezdolap`)}else{const i=await n.json(),r=await N.safeParseAsync(i);return r.success?r.data.errorMessage:"Ismeretlen hiba történt!"}}catch(n){return console.error(n),"Ismeretlen hiba történt!"}},o=async()=>{const t=C.get("oktato-token");if(!(t===void 0||t.length===0))try{(await fetch(u+"/api/profile",{method:"GET",headers:{Authorization:`Bearer ${t}`}})).status===200&&z(`${u}/oktato/kezdolap`)}catch(s){console.error("Auth check failed with error: ",s)}};return P(async()=>{o()}),[a]}class oe extends U{constructor(a){super(),V(this,a,Q,K,q,{})}}export{oe as component};