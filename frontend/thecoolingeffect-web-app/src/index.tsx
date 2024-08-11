import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import PageRoutes from './PageRoutes';
import "bootstrap/dist/css/bootstrap.min.css";
import './App.css';

const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);
root.render(
  <React.StrictMode>
    <PageRoutes />
  </React.StrictMode>
);