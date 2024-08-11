import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.scss';
import PageRoutes from './PageRoutes';
import "bootstrap/dist/css/bootstrap.css";

const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);
root.render(
  <React.StrictMode>
    <PageRoutes />
  </React.StrictMode>
);