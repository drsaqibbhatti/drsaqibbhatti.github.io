:root{
  --bg:#070A12;
  --card: rgba(255,255,255,.06);
  --border: rgba(255,255,255,.12);
  --text: rgba(255,255,255,.92);
  --muted: rgba(255,255,255,.68);
  --shadow: 0 20px 60px rgba(0,0,0,.45);
  --radius: 18px;
}

*{box-sizing:border-box}
html,body{height:100%}
body{
  margin:0;
  font-family: ui-sans-serif, system-ui, -apple-system, Segoe UI, Roboto, Helvetica, Arial;
  background: var(--bg);
  color: var(--text);
}

.bg{
  position:fixed; inset:-20%;
  background:
    radial-gradient(600px 400px at 15% 25%, rgba(99,102,241,.35), transparent 55%),
    radial-gradient(700px 450px at 85% 20%, rgba(16,185,129,.25), transparent 55%),
    radial-gradient(700px 500px at 60% 90%, rgba(236,72,153,.22), transparent 55%),
    linear-gradient(180deg, rgba(255,255,255,.06), transparent 35%);
  filter: blur(10px);
  pointer-events:none;
  z-index:-1;
}

.container{
  width:min(1100px, 92vw);
  margin:0 auto;
}

.nav{
  position:sticky; top:0;
  backdrop-filter: blur(10px);
  background: rgba(7,10,18,.55);
  border-bottom:1px solid rgba(255,255,255,.06);
  z-index:10;
}
.nav-inner{
  display:flex;
  align-items:center;
  justify-content:space-between;
  padding:14px 0;
}
.logo{
  font-weight:800;
  letter-spacing:.2px;
  text-decoration:none;
  color:var(--text);
  font-size:18px;
}
.logo span{opacity:.7}

.links{display:flex; gap:14px; align-items:center}
.links a{
  color:var(--muted);
  text-decoration:none;
  font-weight:600;
  font-size:14px;
}
.links a:hover{color:var(--text)}

.hero{padding:64px 0 18px}
.section{padding:48px 0}
.section-head{display:flex; flex-direction:column; gap:6px; margin-bottom:14px}
.section-head h2{margin:0; font-size:22px}
.section-head p{margin:0; color:var(--muted)}

.card{
  background: var(--card);
  border: 1px solid var(--border);
  border-radius: var(--radius);
  box-shadow: var(--shadow);
  padding: 22px;
}

.hero-card h1{
  margin:10px 0 10px;
  font-size:44px;
  line-height:1.05;
  letter-spacing:-.8px;
}
.sub{color:var(--muted); font-size:16px; line-height:1.6; margin:0 0 16px}

.grad{
  background: linear-gradient(90deg, rgba(99,102,241,1), rgba(16,185,129,1), rgba(236,72,153,1));
  -webkit-background-clip:text;
  background-clip:text;
  color:transparent;
}

.badge{
  display:inline-flex;
  padding:7px 10px;
  border-radius:999px;
  background: rgba(255,255,255,.08);
  border: 1px solid rgba(255,255,255,.12);
  color: var(--muted);
  font-weight:700;
  font-size:12px;
  width:fit-content;
}

.cta{display:flex; gap:10px; flex-wrap:wrap; margin:14px 0 6px}
.btn, .ghost{
  display:inline-flex;
  align-items:center;
  justify-content:center;
  padding:10px 14px;
  border-radius:12px;
  font-weight:800;
  text-decoration:none;
  font-size:14px;
}
.btn{
  color:#070A12;
  background: rgba(255,255,255,.9);
  border: 1px solid rgba(255,255,255,.8);
}
.btn:hover{background:#fff}
.ghost{
  color: var(--text);
  background: rgba(255,255,255,.06);
  border: 1px solid rgba(255,255,255,.12);
}
.ghost:hover{background: rgba(255,255,255,.10)}

.mini{display:flex; gap:10px; flex-wrap:wrap; margin-top:14px}
.pill{
  padding:8px 10px;
  border-radius:999px;
  background: rgba(255,255,255,.06);
  border: 1px solid rgba(255,255,255,.10);
  color: var(--muted);
  font-weight:700;
  font-size:12px;
}

.grid{
  display:grid;
  grid-template-columns: repeat(3, minmax(0, 1fr));
  gap:14px;
}
.card h3{margin:0 0 8px; font-size:18px}
.card p{margin:0 0 12px; color:var(--muted); line-height:1.6}

.tags{display:flex; gap:8px; flex-wrap:wrap; margin-bottom:12px}
.tags span{
  font-size:12px;
  font-weight:800;
  color: var(--muted);
  padding:6px 8px;
  border-radius:999px;
  border:1px solid rgba(255,255,255,.10);
  background: rgba(255,255,255,.05);
}

.row{display:flex; gap:12px}
.link{
  color: rgba(255,255,255,.86);
  font-weight:800;
  text-decoration:none;
  font-size:13px;
}
.link:hover{text-decoration:underline}

.contact{display:flex; gap:10px; flex-wrap:wrap}

.footer{
  padding:26px 0 60px;
  color: rgba(255,255,255,.55);
  font-weight:700;
  font-size:13px;
}

.muted{color:var(--muted)}

@media (max-width: 900px){
  .grid{grid-template-columns: 1fr}
  .hero-card h1{font-size:36px}
  .links{gap:10px}
}
