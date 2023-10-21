import{s as V,n as S,o as U}from"../chunks/scheduler.e108d1fd.js";import{S as F,i as H,g as d,h as g,y as P,k as $,a as T,f as p,s as k,r as D,j,c as L,u as A,l as J,x as h,v as b,d as C,t as E,w as I}from"../chunks/index.13e5c6dd.js";import{b as v}from"../chunks/paths.f55b4c00.js";import{L as M,A as O}from"../chunks/AuthResponse.12e16d39.js";import{L as B,a as G,E as N}from"../chunks/ErrorResponseDto.0a0a36c1.js";import{a as R}from"../chunks/js.cookie.edb2da2a.js";import{U as K}from"../chunks/usertypes.276843e8.js";function Q(u){let t,n="Diák hitel 3 most már elérhető!";return{c(){t=d("div"),t.textContent=n,this.h()},l(s){t=g(s,"DIV",{class:!0,"data-svelte-h":!0}),P(t)!=="svelte-19qhtb4"&&(t.textContent=n),this.h()},h(){$(t,"class","alert alert-warning svelte-q3eogl")},m(s,a){T(s,t,a)},p:S,i:S,o:S,d(s){s&&p(t)}}}class W extends F{constructor(t){super(),H(this,t,null,Q,V,{})}}function X(u){let t,n,s,a,i="Hallgatói belépés",l,r,q,c,_,m,x,f,y;return r=new M({props:{regUrl:`${v}/kozos/regisztracio`,loginHandler:u[0]}}),c=new B({}),m=new W({}),f=new G({}),{c(){t=d("div"),n=d("div"),s=d("div"),a=d("h4"),a.textContent=i,l=k(),D(r.$$.fragment),q=k(),D(c.$$.fragment),_=k(),D(m.$$.fragment),x=k(),D(f.$$.fragment),this.h()},l(e){t=g(e,"DIV",{class:!0});var o=j(t);n=g(o,"DIV",{class:!0,style:!0});var z=j(n);s=g(z,"DIV",{class:!0});var w=j(s);a=g(w,"H4",{class:!0,"data-svelte-h":!0}),P(a)!=="svelte-iu1xvd"&&(a.textContent=i),l=L(w),A(r.$$.fragment,w),w.forEach(p),z.forEach(p),q=L(o),A(c.$$.fragment,o),o.forEach(p),_=L(e),A(m.$$.fragment,e),x=L(e),A(f.$$.fragment,e),this.h()},h(){$(a,"class","card-title"),$(s,"class","card-body svelte-1uctxqa"),$(n,"class","card svelte-1uctxqa"),J(n,"width","20rem"),$(t,"class","container logo-container svelte-1uctxqa")},m(e,o){T(e,t,o),h(t,n),h(n,s),h(s,a),h(s,l),b(r,s,null),h(t,q),b(c,t,null),T(e,_,o),b(m,e,o),T(e,x,o),b(f,e,o),y=!0},p:S,i(e){y||(C(r.$$.fragment,e),C(c.$$.fragment,e),C(m.$$.fragment,e),C(f.$$.fragment,e),y=!0)},o(e){E(r.$$.fragment,e),E(c.$$.fragment,e),E(m.$$.fragment,e),E(f.$$.fragment,e),y=!1},d(e){e&&(p(t),p(_),p(x)),I(r),I(c),I(m,e),I(f,e)}}}function Y(u){const t=async s=>{const a={...s,userType:K.Student};try{const i=await fetch(v+"/api/auth",{method:"POST",body:JSON.stringify(a),headers:{"Content-Type":"application/json"}});if(i.status===200){const l=await O.parseAsync(await i.json()),r=new Date(new Date().getTime()+l.expiresIn*1e3);R.set("token",l.accessToken,{expires:r,path:"/hallgato/",secure:!0,sameSite:"strict"}),window.location.href=`${v}/hallgato/kezdolap`}else{const l=await i.json(),r=await N.safeParseAsync(l);return r.success?r.data.errorMessage:"Ismeretlen hiba történt!"}}catch(i){return console.error(i),"Ismeretlen hiba történt!"}},n=async()=>{const s=R.get("token");if(!(s===void 0||s.length===0))try{(await fetch(v+"/api/profile",{method:"GET",headers:{Authorization:`Bearer ${s}`}})).status===200&&(window.location.href=`${v}/hallgato/kezdolap`)}catch(a){console.error("Auth check failed with error: ",a)}};return U(async()=>{n()}),[t]}class oe extends F{constructor(t){super(),H(this,t,Y,X,V,{})}}export{oe as component};
