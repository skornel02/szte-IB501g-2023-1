import{s as C,f,l as E,a as y,g as u,h as v,m as z,c as b,L,d as _,j as r,i as I,x as d,y as T,n as k,C as x}from"../chunks/scheduler.3ae9c5b3.js";import{S as w,i as B}from"../chunks/index.4a313e9c.js";import{r as D}from"../chunks/rick.5eadafaf.js";function S(o){let t,e,s,i,a,p="X",m,h;return{c(){t=f("div"),e=f("div"),s=E(o[0]),i=y(),a=f("label"),a.textContent=p,this.h()},l(l){t=u(l,"DIV",{class:!0});var n=v(t);e=u(n,"DIV",{class:!0,id:!0});var c=v(e);s=z(c,o[0]),i=b(c),a=u(c,"LABEL",{class:!0,for:!0,"data-svelte-h":!0}),L(a)!=="svelte-2it7zf"&&(a.textContent=p),c.forEach(_),n.forEach(_),this.h()},h(){r(a,"class","btn-close"),r(a,"for","alert-4"),r(e,"class","alert alert-warning dismissible"),r(e,"id","alert"),r(t,"class","container svelte-2wv0un")},m(l,n){I(l,t,n),d(t,e),d(e,s),d(e,i),d(e,a),m||(h=T(a,"click",o[1]),m=!0)},p(l,[n]){n&1&&k(s,l[0])},i:x,o:x,d(l){l&&_(t),m=!1,h()}}}const g="Ezen az oldalon TÉNYLEG nincsen semmi!";function V(o,t,e){let s="Ezen az oldalon nincs semmi!";return[s,()=>{s===g?(D({mouseleave:!0},document.getElementById("alert")),e(0,s="Táncra fel 💃!")):e(0,s=g)}]}class A extends w{constructor(t){super(),B(this,t,V,S,C,{})}}export{A as component};
