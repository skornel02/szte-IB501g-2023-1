var B=Object.defineProperty;var q=(t,n,e)=>n in t?B(t,n,{enumerable:!0,configurable:!0,writable:!0,value:e}):t[n]=e;var f=(t,n,e)=>(q(t,typeof n!="symbol"?n+"":n,e),e);function I(){}const lt=t=>t;function O(t,n){for(const e in n)t[e]=n[e];return t}function R(t){return t()}function rt(){return Object.create(null)}function F(t){t.forEach(R)}function ot(t){return typeof t=="function"}function at(t,n){return t!=t?n==n:t!==n||t&&typeof t=="object"||typeof t=="function"}function ut(t){return Object.keys(t).length===0}function G(t,...n){if(t==null){for(const i of n)i(void 0);return I}const e=t.subscribe(...n);return e.unsubscribe?()=>e.unsubscribe():e}function ft(t,n,e){t.$$.on_destroy.push(G(n,e))}function _t(t,n,e,i){if(t){const s=M(t,n,e,i);return t[0](s)}}function M(t,n,e,i){return t[1]&&i?O(e.ctx.slice(),t[1](i(n))):e.ctx}function dt(t,n,e,i){if(t[2]&&i){const s=t[2](i(e));if(n.dirty===void 0)return s;if(typeof s=="object"){const o=[],c=Math.max(n.dirty.length,s.length);for(let r=0;r<c;r+=1)o[r]=n.dirty[r]|s[r];return o}return n.dirty|s}return n.dirty}function ht(t,n,e,i,s,o){if(s){const c=M(n,e,i,o);t.p(c,s)}}function mt(t){if(t.ctx.length>32){const n=[],e=t.ctx.length/32;for(let i=0;i<e;i++)n[i]=-1;return n}return-1}function pt(t){const n={};for(const e in t)e[0]!=="$"&&(n[e]=t[e]);return n}function yt(t){return t??""}function gt(t){const n=typeof t=="string"&&t.match(/^\s*(-?[\d.]+)([^\s]*)\s*$/);return n?[parseFloat(n[1]),n[2]||"px"]:[t,"px"]}let p=!1;function bt(){p=!0}function xt(){p=!1}function z(t,n,e,i){for(;t<n;){const s=t+(n-t>>1);e(s)<=i?t=s+1:n=s}return t}function U(t){if(t.hydrate_init)return;t.hydrate_init=!0;let n=t.childNodes;if(t.nodeName==="HEAD"){const l=[];for(let a=0;a<n.length;a++){const u=n[a];u.claim_order!==void 0&&l.push(u)}n=l}const e=new Int32Array(n.length+1),i=new Int32Array(n.length);e[0]=-1;let s=0;for(let l=0;l<n.length;l++){const a=n[l].claim_order,u=(s>0&&n[e[s]].claim_order<=a?s+1:z(1,s,D=>n[e[D]].claim_order,a))-1;i[l]=e[u]+1;const T=u+1;e[T]=l,s=Math.max(T,s)}const o=[],c=[];let r=n.length-1;for(let l=e[s]+1;l!=0;l=i[l-1]){for(o.push(n[l-1]);r>=l;r--)c.push(n[r]);r--}for(;r>=0;r--)c.push(n[r]);o.reverse(),c.sort((l,a)=>l.claim_order-a.claim_order);for(let l=0,a=0;l<c.length;l++){for(;a<o.length&&c[l].claim_order>=o[a].claim_order;)a++;const u=a<o.length?o[a]:null;t.insertBefore(c[l],u)}}function W(t,n){t.appendChild(n)}function J(t){if(!t)return document;const n=t.getRootNode?t.getRootNode():t.ownerDocument;return n&&n.host?n:t.ownerDocument}function Et(t){const n=v("style");return n.textContent="/* empty */",K(J(t),n),n.sheet}function K(t,n){return W(t.head||t,n),n.sheet}function Q(t,n){if(p){for(U(t),(t.actual_end_child===void 0||t.actual_end_child!==null&&t.actual_end_child.parentNode!==t)&&(t.actual_end_child=t.firstChild);t.actual_end_child!==null&&t.actual_end_child.claim_order===void 0;)t.actual_end_child=t.actual_end_child.nextSibling;n!==t.actual_end_child?(n.claim_order!==void 0||n.parentNode!==t)&&t.insertBefore(n,t.actual_end_child):t.actual_end_child=n.nextSibling}else(n.parentNode!==t||n.nextSibling!==null)&&t.appendChild(n)}function V(t,n,e){t.insertBefore(n,e||null)}function X(t,n,e){p&&!e?Q(t,n):(n.parentNode!==t||n.nextSibling!=e)&&t.insertBefore(n,e||null)}function x(t){t.parentNode&&t.parentNode.removeChild(t)}function Nt(t,n){for(let e=0;e<t.length;e+=1)t[e]&&t[e].d(n)}function v(t){return document.createElement(t)}function H(t){return document.createElementNS("http://www.w3.org/2000/svg",t)}function w(t){return document.createTextNode(t)}function vt(){return w(" ")}function wt(){return w("")}function Tt(t,n,e,i){return t.addEventListener(n,e,i),()=>t.removeEventListener(n,e,i)}function kt(t){return function(n){return n.preventDefault(),t.call(this,n)}}function At(t){return function(n){return n.stopPropagation(),t.call(this,n)}}function Lt(t){return function(n){n.target===this&&t.call(this,n)}}function Y(t,n,e){e==null?t.removeAttribute(n):t.getAttribute(n)!==e&&t.setAttribute(n,e)}function Mt(t,n){for(const e in n)Y(t,e,n[e])}function Ht(t){return t.dataset.svelteH}function Pt(t){return t===""?null:+t}function St(t){return Array.from(t.childNodes)}function P(t){t.claim_info===void 0&&(t.claim_info={last_index:0,total_claimed:0})}function S(t,n,e,i,s=!1){P(t);const o=(()=>{for(let c=t.claim_info.last_index;c<t.length;c++){const r=t[c];if(n(r)){const l=e(r);return l===void 0?t.splice(c,1):t[c]=l,s||(t.claim_info.last_index=c),r}}for(let c=t.claim_info.last_index-1;c>=0;c--){const r=t[c];if(n(r)){const l=e(r);return l===void 0?t.splice(c,1):t[c]=l,s?l===void 0&&t.claim_info.last_index--:t.claim_info.last_index=c,r}}return i()})();return o.claim_order=t.claim_info.total_claimed,t.claim_info.total_claimed+=1,o}function j(t,n,e,i){return S(t,s=>s.nodeName===n,s=>{const o=[];for(let c=0;c<s.attributes.length;c++){const r=s.attributes[c];e[r.name]||o.push(r.name)}o.forEach(c=>s.removeAttribute(c))},()=>i(n))}function jt(t,n,e){return j(t,n,e,v)}function Ct(t,n,e){return j(t,n,e,H)}function Z(t,n){return S(t,e=>e.nodeType===3,e=>{const i=""+n;if(e.data.startsWith(i)){if(e.data.length!==i.length)return e.splitText(i.length)}else e.data=i},()=>w(n),!0)}function Dt(t){return Z(t," ")}function k(t,n,e){for(let i=e;i<t.length;i+=1){const s=t[i];if(s.nodeType===8&&s.textContent.trim()===n)return i}return-1}function Bt(t,n){const e=k(t,"HTML_TAG_START",0),i=k(t,"HTML_TAG_END",e+1);if(e===-1||i===-1)return new A(n);P(t);const s=t.splice(e,i-e+1);x(s[0]),x(s[s.length-1]);const o=s.slice(1,s.length-1);for(const c of o)c.claim_order=t.claim_info.total_claimed,t.claim_info.total_claimed+=1;return new A(n,o)}function qt(t,n){n=""+n,t.data!==n&&(t.data=n)}function It(t,n){t.value=n??""}function Ot(t,n,e,i){e==null?t.style.removeProperty(n):t.style.setProperty(n,e,i?"important":"")}function Rt(t,n,e){for(let i=0;i<t.options.length;i+=1){const s=t.options[i];if(s.__value===n){s.selected=!0;return}}(!e||n!==void 0)&&(t.selectedIndex=-1)}function Ft(t){const n=t.querySelector(":checked");return n&&n.__value}function Gt(t,n,e){t.classList.toggle(n,!!e)}function $(t,n,{bubbles:e=!1,cancelable:i=!1}={}){return new CustomEvent(t,{detail:n,bubbles:e,cancelable:i})}class tt{constructor(n=!1){f(this,"is_svg",!1);f(this,"e");f(this,"n");f(this,"t");f(this,"a");this.is_svg=n,this.e=this.n=null}c(n){this.h(n)}m(n,e,i=null){this.e||(this.is_svg?this.e=H(e.nodeName):this.e=v(e.nodeType===11?"TEMPLATE":e.nodeName),this.t=e.tagName!=="TEMPLATE"?e:e.content,this.c(n)),this.i(i)}h(n){this.e.innerHTML=n,this.n=Array.from(this.e.nodeName==="TEMPLATE"?this.e.content.childNodes:this.e.childNodes)}i(n){for(let e=0;e<this.n.length;e+=1)V(this.t,this.n[e],n)}p(n){this.d(),this.h(n),this.i(this.a)}d(){this.n.forEach(x)}}class A extends tt{constructor(e=!1,i){super(e);f(this,"l");this.e=this.n=null,this.l=i}c(e){this.l?this.n=this.l:super.c(e)}i(e){for(let i=0;i<this.n.length;i+=1)X(this.t,this.n[i],e)}}function zt(t,n){return new t(n)}let m;function g(t){m=t}function y(){if(!m)throw new Error("Function called outside component initialization");return m}function Ut(t){y().$$.on_mount.push(t)}function Wt(t){y().$$.after_update.push(t)}function Jt(t){y().$$.on_destroy.push(t)}function Kt(){const t=y();return(n,e,{cancelable:i=!1}={})=>{const s=t.$$.callbacks[n];if(s){const o=$(n,e,{cancelable:i});return s.slice().forEach(c=>{c.call(t,o)}),!o.defaultPrevented}return!0}}function Qt(t,n){const e=t.$$.callbacks[n.type];e&&e.slice().forEach(i=>i.call(this,n))}const h=[],L=[];let d=[];const E=[],C=Promise.resolve();let N=!1;function nt(){N||(N=!0,C.then(it))}function Vt(){return nt(),C}function et(t){d.push(t)}function Xt(t){E.push(t)}const b=new Set;let _=0;function it(){if(_!==0)return;const t=m;do{try{for(;_<h.length;){const n=h[_];_++,g(n),st(n.$$)}}catch(n){throw h.length=0,_=0,n}for(g(null),h.length=0,_=0;L.length;)L.pop()();for(let n=0;n<d.length;n+=1){const e=d[n];b.has(e)||(b.add(e),e())}d.length=0}while(h.length);for(;E.length;)E.pop()();N=!1,b.clear(),g(t)}function st(t){if(t.fragment!==null){t.update(),F(t.before_update);const n=t.dirty;t.dirty=[-1],t.fragment&&t.fragment.p(t.ctx,n),t.after_update.forEach(et)}}function Yt(t){const n=[],e=[];d.forEach(i=>t.indexOf(i)===-1?n.push(i):e.push(i)),e.forEach(i=>i()),d=n}export{Xt as $,ft as A,Jt as B,I as C,Bt as D,yt as E,et as F,_t as G,A as H,ht as I,mt as J,dt as K,Ht as L,Nt as M,kt as N,It as O,Rt as P,Pt as Q,Ft as R,H as S,Ct as T,Mt as U,pt as V,Lt as W,At as X,Kt as Y,ot as Z,Qt as _,vt as a,J as a0,Et as a1,$ as a2,rt as a3,it as a4,ut as a5,Yt as a6,m as a7,g as a8,R as a9,h as aa,nt as ab,bt as ac,xt as ad,Wt as b,Dt as c,x as d,wt as e,v as f,jt as g,St as h,X as i,Y as j,Ot as k,w as l,Z as m,qt as n,Ut as o,L as p,zt as q,gt as r,at as s,Vt as t,lt as u,O as v,Gt as w,Q as x,Tt as y,F as z};