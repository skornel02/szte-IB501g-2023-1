import{s as j,n as v}from"../chunks/scheduler.e108d1fd.js";import{S as q,i as A,g as $,h as p,y as E,k as h,a as x,f as d,s as y,r as C,j as V,c as b,u as w,l as S,x as L,v as k,d as D,t as H,w as I}from"../chunks/index.a8e6cd80.js";import{b as z}from"../chunks/paths.18e33510.js";import{L as F,a as J}from"../chunks/LoginJunk.44eeb421.js";function P(m){let t,s="Diák hitel 3 most már elérhető!";return{c(){t=$("div"),t.textContent=s,this.h()},l(a){t=p(a,"DIV",{class:!0,"data-svelte-h":!0}),E(t)!=="svelte-19qhtb4"&&(t.textContent=s),this.h()},h(){h(t,"class","alert alert-warning svelte-498bg7")},m(a,c){x(a,t,c)},p:v,i:v,o:v,d(a){a&&d(t)}}}class U extends q{constructor(t){super(),A(this,t,null,P,j,{})}}function B(m){let t,s,a,c="Hallgatói belépés",n,l,f,i,g,o,u;return l=new F({props:{regUrl:`${z}/hallgato/regisztracio`,loginHandler:m[0]}}),i=new U({}),o=new J({}),{c(){t=$("div"),s=$("div"),a=$("h4"),a.textContent=c,n=y(),C(l.$$.fragment),f=y(),C(i.$$.fragment),g=y(),C(o.$$.fragment),this.h()},l(e){t=p(e,"DIV",{class:!0,style:!0});var r=V(t);s=p(r,"DIV",{class:!0});var _=V(s);a=p(_,"H4",{class:!0,"data-svelte-h":!0}),E(a)!=="svelte-iu1xvd"&&(a.textContent=c),n=b(_),w(l.$$.fragment,_),_.forEach(d),r.forEach(d),f=b(e),w(i.$$.fragment,e),g=b(e),w(o.$$.fragment,e),this.h()},h(){h(a,"class","card-title"),h(s,"class","card-body svelte-17u2gt9"),h(t,"class","card svelte-17u2gt9"),S(t,"width","20rem")},m(e,r){x(e,t,r),L(t,s),L(s,a),L(s,n),k(l,s,null),x(e,f,r),k(i,e,r),x(e,g,r),k(o,e,r),u=!0},p:v,i(e){u||(D(l.$$.fragment,e),D(i.$$.fragment,e),D(o.$$.fragment,e),u=!0)},o(e){H(l.$$.fragment,e),H(i.$$.fragment,e),H(o.$$.fragment,e),u=!1},d(e){e&&(d(t),d(f),d(g)),I(l),I(i,e),I(o,e)}}}function G(m,t,s){let{data:a}=t;const c=async n=>{console.log(n)};return m.$$set=n=>{"data"in n&&s(1,a=n.data)},[c,a]}class Q extends q{constructor(t){super(),A(this,t,G,B,j,{data:1})}}export{Q as component};
